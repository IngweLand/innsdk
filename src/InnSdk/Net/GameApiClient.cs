using Ingweland.Fog.Inn.Models.Core;
using Ingweland.Fog.Inn.Models.Foe;
using Ingweland.Fog.Inn.Sdk.Abstractions;
using Ingweland.Fog.Inn.Sdk.Authentication;
using Ingweland.Fog.Inn.Sdk.Authentication.Model;
using Ingweland.Fog.Inn.Sdk.Exceptions;
using Ingweland.Fog.Inn.Sdk.Models.Abstractions;
using Ingweland.Fog.Inn.Sdk.Net.Abstractions;
using Ingweland.Fog.Inn.Sdk.Services.Abstractions;
using Newtonsoft.Json;
using Polly;
using Polly.Retry;

namespace Ingweland.Fog.Inn.Sdk.Net;

public abstract class GameApiClient : IGameApiClient
{
    private readonly SemaphoreSlim _authenticationMutex = new(1, 1);
    private readonly IGameAuthenticationService _authenticationService;

    protected GameApiClient(IHttpClientFactory httpClientFactory, IGameConnectionManager connectionManager,
        IGameAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
        ConnectionManager = connectionManager;
        HttpClient = httpClientFactory.CreateClient(HttpClientKeys.DEFAULT);
        ReauthenticatePipeline = new ResiliencePipelineBuilder<string>().AddRetry(new RetryStrategyOptions<string>
        {
            ShouldHandle = args => ValueTask.FromResult(args.Outcome.Exception is AuthenticationException
            {
                ErrorCode: AuthErrorCode.InvalidToken,
            }),
            OnRetry = _ =>
            {
                Console.Out.WriteLine("Re-authing due to invalid token...");
                return ValueTask.CompletedTask;
            },
            Delay = TimeSpan.FromMilliseconds(100),
            MaxRetryAttempts = 1,
        }).Build();
    }

    protected IGameConnectionManager ConnectionManager { get; }

    protected HttpClient HttpClient { get; }

    protected ResiliencePipeline<string> ReauthenticatePipeline { get; }

    public Task<HttpResponseMessage> PostAsync(string requestUrl, HttpContent content,
        CancellationToken cancellationToken = default)
    {
        content.Headers.Add("X-Requested-With", "XMLHttpRequest");
        return HttpClient.PostAsync(requestUrl, content, cancellationToken);
    }

    public Task<IReadOnlyCollection<ServerResponse>> SendAsync(GameWorldConfig world, IServerRequest serverRequest)
    {
        return SendAsync(world, [serverRequest]);
    }

    public async Task<IReadOnlyCollection<ServerResponse>> SendAsync(GameWorldConfig world,
        IEnumerable<IServerRequest> payload)
    {
        var response = await LoadAsync(world, payload);

        try
        {
            var parsedResponse = JsonConvert.DeserializeObject<IList<FoeJsonResponse>>(response);
            var allResults = parsedResponse!.Where(r => r.Response is ServerResponse)
                .Select<dynamic, ServerResponse>(r => r.Response).ToList();

            return allResults.AsReadOnly();
        }
        catch (Exception e)
        {
            throw new ServerResponseException("An error occurred while parsing the server response.",
                JsonConvert.SerializeObject(payload), response, e);
        }
    }

    public abstract Task<string> LoadAsync(GameWorldConfig world, IEnumerable<IServerRequest> payload);

    protected async Task EnsureAuthenticated(GameWorldConfig world)
    {
        await _authenticationMutex.WaitAsync();
        if (ConnectionManager.Get(world.Id) != null)
        {
            _authenticationMutex.Release();
        }
        else
        {
            try
            {
                await _authenticationService.Authenticate(world);
            }
            finally
            {
                _authenticationMutex.Release();
            }
        }
    }
}

using Ingweland.Fog.Inn.Models.Core;
using Ingweland.Fog.Inn.Sdk.Abstractions;
using Ingweland.Fog.Inn.Sdk.Authentication.Abstractions;
using Ingweland.Fog.Inn.Sdk.Authentication.Model;
using Ingweland.Fog.Inn.Sdk.Constants;
using Ingweland.Fog.Inn.Sdk.Net;
using Ingweland.Fog.Inn.Sdk.Services.Abstractions;
using Polly;
using Polly.Retry;

namespace Ingweland.Fog.Inn.Sdk.Authentication;

public class FoeMobileAuthenticationService(
    IFoeMobileAuthPayloadFactory authPayloadFactory,
    IHttpClientFactory httpClientFactory,
    IFoeMobileAuthenticationResponseHandler authenticationResponseHandler,
    IGameCredentialsManager credentialsManager,
    IGameConnectionManager connectionManager) : IFoeMobileAuthenticationService
{
    private readonly HttpClient _httpClient = httpClientFactory.CreateClient(HttpClientKeys.DEFAULT);

    private readonly ResiliencePipeline _reauthenticatePipeline = new ResiliencePipelineBuilder().AddRetry(
        new RetryStrategyOptions
        {
            ShouldHandle = args => ValueTask.FromResult(args.Outcome.Exception is AuthenticationException
            {
                ErrorCode: AuthErrorCode.UserBanned,
            }),
            OnRetry = _ =>
            {
                Console.Out.WriteLine("User is banned. Picking a new one...");
                return ValueTask.CompletedTask;
            },
            Delay = TimeSpan.FromMilliseconds(500),
            BackoffType = DelayBackoffType.Exponential,
            MaxRetryAttempts = 3,
        }).Build();

    public Task Authenticate(GameWorldConfig world)
    {
        return _reauthenticatePipeline.ExecuteAsync(async ct =>
        {
            Console.Out.WriteLine($"Authenticating on {world.Id}");
            var credentials = await credentialsManager.GetAsync(OriginalGame.Foe, world);
            var payload = authPayloadFactory.Create(credentials);
            var url = string.Format(Urls.MOBILE_LOGIN, world.Server);
            var responseMessage = await _httpClient.PostAsync(url, payload, ct);
            var response = await responseMessage.Content.ReadAsStringAsync(ct);
            try
            {
                var config = authenticationResponseHandler.HandleResponse(response);
                connectionManager.AddOrUpdate(config);
            }
            catch (AuthenticationException e)
            {
                await credentialsManager.ReportAuthIssueAsync(credentials, e.ErrorCode);
                throw;
            }

            return ValueTask.CompletedTask;
        }).AsTask();
    }
}

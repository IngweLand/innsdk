using Ingweland.Fog.Inn.Sdk.Abstractions;
using Ingweland.Fog.Inn.Sdk.Authentication;
using Ingweland.Fog.Inn.Sdk.Authentication.Model;
using Ingweland.Fog.Inn.Sdk.Exceptions;
using Ingweland.Fog.Inn.Sdk.Helpers;
using Ingweland.Fog.Inn.Sdk.Models.Abstractions;
using Ingweland.Fog.Inn.Sdk.Net.Abstractions;
using Ingweland.Fog.Inn.Sdk.Services.Abstractions;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Sdk.Net;

public class FoeApiClient : GameApiClient, IFoeApiClient
{
    private readonly IFoeRequestContentFactory _requestContentFactory;

    public FoeApiClient(IHttpClientFactory httpClientFactory, IFoeMobileAuthenticationService authenticationService,
        IGameConnectionManager connectionManager, IFoeRequestContentFactory requestContentFactory) : base(
        httpClientFactory, connectionManager, authenticationService)
    {
        _requestContentFactory = requestContentFactory;
    }

    public override Task<string> LoadAsync(GameWorldConfig world, IEnumerable<IServerRequest> payload)
    {
        var payloadString = JsonConvert.SerializeObject(payload);
        return ReauthenticatePipeline.ExecuteAsync(async ct =>
        {
            await EnsureAuthenticated(world);
            var content = await _requestContentFactory.CreateAsync(payloadString, world);
            var csrfToken = ConnectionManager.Get(world.Id)!.CsrfToken;
            var responseMessage = await PostAsync(UrlBuilder.BuildMainUrl(worldId: world.Id, csrfToken: csrfToken),
                content, ct);
            var response = await responseMessage.Content.ReadAsStringAsync(ct);

            if (string.IsNullOrWhiteSpace(response))
            {
                throw new ServerResponseException("The server returned an empty or invalid response.", payloadString,
                    response);
            }

            if (response.Contains("""__class__":"Error"""))
            {
                throw new OriginalGameException(
                    "The server encountered errors processing one or more items in the request payload.", payloadString,
                    response);
            }

            if (response.Contains("""__class__":"Redirect"""))
            {
                ConnectionManager.Remove(world.Id);
                throw new AuthenticationException(AuthErrorCode.InvalidToken);
            }

            return response;
        }).AsTask();
    }
}

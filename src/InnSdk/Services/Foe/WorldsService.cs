using Ingweland.Fog.Inn.Models.Core;
using Ingweland.Fog.Inn.Models.Foe;
using Ingweland.Fog.Inn.Sdk.Abstractions;
using Ingweland.Fog.Inn.Sdk.Authentication;
using Ingweland.Fog.Inn.Sdk.Authentication.Abstractions;
using Ingweland.Fog.Inn.Sdk.Authentication.Model;
using Ingweland.Fog.Inn.Sdk.Constants;
using Ingweland.Fog.Inn.Sdk.Net;
using Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;

namespace Ingweland.Fog.Inn.Sdk.Services.Foe;

public class WorldsService(
    IFoeMobileAuthPayloadFactory authPayloadFactory,
    IHttpClientFactory httpClientFactory,
    IFoeMobilePreloginResponseHandler responseHandler,
    IGameCredentialsManager credentialsManager) : IWorldsService
{
    private readonly HttpClient _httpClient = httpClientFactory.CreateClient(HttpClientKeys.DEFAULT);

    public async Task<IReadOnlyCollection<FJWorld>> GetWorlds(string server)
    {
        var world = new GameWorldConfig(server, 1);
        var credentials = await credentialsManager.GetAsync(OriginalGame.Foe, world);
        var payload = authPayloadFactory.Create(credentials);
        var url = string.Format(Urls.MOBILE_PRELOGIN, world.Server);
        var responseMessage = await _httpClient.PostAsync(url, payload);
        var response = await responseMessage.Content.ReadAsStringAsync();
        try
        {
            return responseHandler.HandleResponse(response).Worlds;
        }
        catch (AuthenticationException e)
        {
            await credentialsManager.ReportAuthIssueAsync(credentials, e.ErrorCode);
            if (e.ErrorCode == AuthErrorCode.UserBanned)
            {
                //TODO: retry with a new credentials
            }

            throw;
        }
    }
}

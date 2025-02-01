using Ingweland.Fog.Inn.Models.Core;
using Ingweland.Fog.Inn.Sdk.Abstractions;
using Ingweland.Fog.Inn.Sdk.Authentication.Abstractions;
using Ingweland.Fog.Inn.Sdk.Authentication.Model;
using Ingweland.Fog.Inn.Sdk.Helpers;
using Ingweland.Fog.Inn.Sdk.Models;

namespace Ingweland.Fog.Inn.Sdk.Authentication;

public class FoeWebAuthenticationService(
    IFoeWebAuthPayloadFactory authPayloadFactory,
    IHttpClientFactory httpClientFactory,
    IFoeWebAuthenticationResponseHandler authenticationResponseHandler,
    IGameCredentialsManager credentialsManager) : FoeWebsiteServiceBase, IFoeWebAuthenticationService
{
    public async Task<GameServerWebConnectionData> Authenticate(GameWorldConfig world)
    {
        await LoadStartPage(UrlBuilder.BuildBaseUrl(world.Server));
        await Step1(world);
        await Step2(world.Server);
        var url = await Step3(world);
        return await Step4(url);
    }

    private async Task Step1(GameWorldConfig world)
    {
        var credentials = await credentialsManager.GetAsync(OriginalGame.Foe, world);
        var payload = authPayloadFactory.CreateForStep1(credentials);
        var responseMessage = await RetryPipeline.ExecuteAsync(async ct =>
            await HttpClient.PostAsync(UrlBuilder.BuildWebPreloginUrl(world.Server), payload, ct));
        var response = await responseMessage.Content.ReadAsStringAsync();

        try
        {
            authenticationResponseHandler.CheckAuthentication(response);
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

    private async Task Step2(string server)
    {
        await RetryPipeline.ExecuteAsync(async ct => await HttpClient.GetAsync(UrlBuilder.BuildBaseUrl(server), ct));
    }

    private async Task<string> Step3(GameWorldConfig world)
    {
        var payload = authPayloadFactory.CreateForStep2(world.Id);
        var responseMessage = await RetryPipeline.ExecuteAsync(async ct =>
            await HttpClient.PostAsync(UrlBuilder.BuildWebPlayNowLoginUrl(world.Server), payload, ct));
        var response = await responseMessage.Content.ReadAsStringAsync();
        return authenticationResponseHandler.GetLoginUrl(response);
    }

    private async Task<GameServerWebConnectionData> Step4(string url)
    {
        var responseMessage = await RetryPipeline.ExecuteAsync(async ct => await HttpClient.GetAsync(url, ct));
        var response = await responseMessage.Content.ReadAsStringAsync();
        return authenticationResponseHandler.CreateConnectionData(response);
    }
}

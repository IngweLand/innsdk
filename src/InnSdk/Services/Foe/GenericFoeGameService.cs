using Ingweland.Fog.Inn.Models.Foe;
using Ingweland.Fog.Inn.Sdk.Authentication.Abstractions;
using Ingweland.Fog.Inn.Sdk.Authentication.Model;
using Ingweland.Fog.Inn.Sdk.Constants;
using Ingweland.Fog.Inn.Sdk.Net;
using Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Sdk.Services.Foe;

public class GenericFoeGameService(
    IHttpClientFactory httpClientFactory,
    IFoeWebAuthenticationService authenticationService) : IGenericFoeGameService
{
    private readonly HttpClient _httpClient = httpClientFactory.CreateClient(HttpClientKeys.WEB);

    public async Task<string?> GetGameEngineAsync(string server)
    {
        var world = new GameWorldConfig(server, 1);
        var connectionData = await authenticationService.Authenticate(world);
        return await _httpClient.GetStringAsync(connectionData.GameEngineUrl);
    }

    public async Task<Stream?> GetLocaleFileStreamAsync(string server)
    {
        var world = new GameWorldConfig(server, 1);
        var connectionData = await authenticationService.Authenticate(world);

        var url = connectionData.Basepath + "lang/" + connectionData.Locale + "/client_lang-" +
            connectionData.LangHash + ".mo";
        return new MemoryStream(await _httpClient.GetByteArrayAsync(url));
    }

    public async Task<IReadOnlyCollection<ServerConfig>> GetServerConfigsAsync()
    {
        var response = await _httpClient.GetStringAsync(Urls.SERVER_CONFIGS);
        return JsonConvert.DeserializeObject<Servers>(response)!.Markets.Values.ToList().AsReadOnly();
    }
}

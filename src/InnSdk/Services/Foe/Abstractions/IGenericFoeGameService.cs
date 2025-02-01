using Ingweland.Fog.Inn.Models.Foe;

namespace Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;

public interface IGenericFoeGameService
{
    Task<string?> GetGameEngineAsync(string server);
    Task<Stream?> GetLocaleFileStreamAsync(string server);
    Task<IReadOnlyCollection<ServerConfig>> GetServerConfigsAsync();
}

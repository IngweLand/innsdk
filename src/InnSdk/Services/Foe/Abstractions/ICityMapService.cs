using Ingweland.Fog.Inn.Sdk.Authentication.Model;

namespace Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;

public interface ICityMapService
{
    Task<string> LoadCityMapAsync(GameWorldConfig world, string mapId);
    Task<string> LoadEntitiesAsync(GameWorldConfig world, string mapId);
}

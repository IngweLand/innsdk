using Ingweland.Fog.Inn.Sdk.Authentication.Model;
using Ingweland.Fog.Inn.Sdk.Models.Abstractions;
using Ingweland.Fog.Inn.Sdk.Net.Abstractions;
using Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;

namespace Ingweland.Fog.Inn.Sdk.Services.Foe;

public class CityMapService(IFoeApiClient gameApiClient) : GameServiceBase(gameApiClient), ICityMapService
{
    private const string REQUEST_CLASS = "CityMapService";

    public Task<string> LoadCityMapAsync(GameWorldConfig world, string mapId)
    {
        var payload = new List<GetCityMapRequest> {new(mapId)};
        return GameApiClient.LoadAsync(world, payload);
    }

    public Task<string> LoadEntitiesAsync(GameWorldConfig world, string mapId)
    {
        var payload = new List<GetEntitiesRequest> {new(mapId)};
        return GameApiClient.LoadAsync(world, payload);
    }

    private abstract class CityMapServiceRequestBase(string method, string mapId)
        : ServerRequestBase(REQUEST_CLASS, method)
    {
        protected override object?[] GetRequestData() => [mapId];
    }

    private class GetCityMapRequest(string mapId) : CityMapServiceRequestBase(METHOD, mapId)
    {
        private const string METHOD = "getCityMap";
    }

    private class GetEntitiesRequest(string mapId) : CityMapServiceRequestBase(METHOD, mapId)
    {
        private const string METHOD = "getEntities";
    }
}

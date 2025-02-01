using Ingweland.Fog.Inn.Models.Core;
using Ingweland.Fog.Inn.Models.Foe;
using Ingweland.Fog.Inn.Sdk.Authentication.Model;
using Ingweland.Fog.Inn.Sdk.Extensions;
using Ingweland.Fog.Inn.Sdk.Models.Abstractions;
using Ingweland.Fog.Inn.Sdk.Net.Abstractions;
using Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Sdk.Services.Foe;

public class OtherPlayerService(IFoeApiClient gameApiClient) : GameServiceBase(gameApiClient), IOtherPlayerService
{
    private const string REQUEST_CLASS = "OtherPlayerService";

    public async Task<FJOtherPlayerCity?> GetOtherPlayerByIdAsync(GameWorldConfig world, int playerId)
    {
        var payload = new VisitPlayerRequest() {PlayerId = playerId};
        var response = await GameApiClient.SendAsync(world, payload);
        return VisitPlayerResponse(response).FirstOrDefault();
    }

    public async Task<FJCityMapEntity?> GetOtherPlayerCityMapEntityAsync(GameWorldConfig world, int cityMapEntityId,
        int playerId)
    {
        var payload = new GetOtherPlayerCityMapEntityRequest {CityMapEntityId = cityMapEntityId, PlayerId = playerId};
        var response = await GameApiClient.SendAsync(world, payload);
        return GetOtherPlayerCityMapEntityResponse(response).FirstOrDefault();
    }

    public async Task<IReadOnlyCollection<FJOtherPlayerCity>> GetOtherPlayersByIdsAsync(GameWorldConfig world,
        IList<int> playerIds)
    {
        var payload = new List<VisitPlayerRequest>();
        foreach (var playerId in playerIds)
        {
            payload.Add(new VisitPlayerRequest() {PlayerId = playerId});
        }

        var response = await GameApiClient.SendAsync(world, payload);
        return VisitPlayerResponse(response);
    }

    public Task<string> LoadOtherPlayerByIdAsync(GameWorldConfig world, int playerId)
    {
        var payload = new List<VisitPlayerRequest> {new() {PlayerId = playerId}};
        return GameApiClient.LoadAsync(world, payload);
    }

    public Task<string> LoadOtherPlayerCityMapEntityAsync(GameWorldConfig world, int cityMapEntityId, int playerId)
    {
        var payload = new GetOtherPlayerCityMapEntityRequest {CityMapEntityId = cityMapEntityId, PlayerId = playerId};
        return GameApiClient.LoadAsync(world, new[] {payload});
    }

    public Task<string> LoadOtherPlayersByIdsAsync(GameWorldConfig world, IList<int> playerIds)
    {
        var payload = new List<VisitPlayerRequest>();
        foreach (var playerId in playerIds)
        {
            payload.Add(new VisitPlayerRequest() {PlayerId = playerId});
        }

        return GameApiClient.LoadAsync(world, payload);
    }

    public Task<string> LoadOtherPlayerVoByIdAsync(GameWorldConfig world, int playerId)
    {
        var payload = new List<GetOtherPlayerVORequest> {new() {PlayerId = playerId}};
        return GameApiClient.LoadAsync(world, payload);
    }

    private static IReadOnlyCollection<FJCityMapEntity> GetOtherPlayerCityMapEntityResponse(
        IEnumerable<ServerResponse> data)
    {
        return data.FindAllAndConvert<FJCityMapEntity>(REQUEST_CLASS, GetOtherPlayerCityMapEntityRequest.METHOD);
    }

    private static IReadOnlyCollection<FJOtherPlayerCity> VisitPlayerResponse(IEnumerable<ServerResponse> data)
    {
        return data.FindAllAndConvert<FJOtherPlayerCity>(REQUEST_CLASS, VisitPlayerRequest.METHOD);
    }

    public class VisitPlayerRequest() : ServerRequestBase(REQUEST_CLASS, METHOD)
    {
        public const string METHOD = "visitPlayer";

        [JsonIgnore]
        public required int PlayerId { get; init; }

        protected override object?[] GetRequestData()
        {
            return [PlayerId];
        }
    }

    public class GetOtherPlayerCityMapEntityRequest() : ServerRequestBase(REQUEST_CLASS, METHOD)
    {
        public const string METHOD = "getOtherPlayerCityMapEntity";

        [JsonIgnore]
        public required int CityMapEntityId { get; init; }

        [JsonIgnore]
        public required int PlayerId { get; init; }

        protected override object?[] GetRequestData()
        {
            return [CityMapEntityId, PlayerId];
        }
    }

    public class GetOtherPlayerVORequest() : ServerRequestBase(REQUEST_CLASS, METHOD)
    {
        public const string METHOD = "getOtherPlayerVO";

        [JsonIgnore]
        public required int PlayerId { get; init; }

        protected override object?[] GetRequestData()
        {
            return [PlayerId];
        }
    }
}

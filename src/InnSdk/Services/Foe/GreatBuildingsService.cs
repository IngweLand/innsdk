using Ingweland.Fog.Inn.Models.Core;
using Ingweland.Fog.Inn.Models.Foe;
using Ingweland.Fog.Inn.Sdk.Authentication.Model;
using Ingweland.Fog.Inn.Sdk.Extensions;
using Ingweland.Fog.Inn.Sdk.Models.Abstractions;
using Ingweland.Fog.Inn.Sdk.Net.Abstractions;
using Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Sdk.Services.Foe;

public class GreatBuildingsService(IFoeApiClient gameApiClient) : GameServiceBase(gameApiClient), IGreatBuildingsService
{
    private const string REQUEST_CLASS = "GreatBuildingsService";

    public Task<string> LoadConstructionAsync(GameWorldConfig world, int playerId, int cityMapEntityId)
    {
        var payload = new List<ServerRequestBase>
        {
            new GetConstructionRequest
            {
                PlayerId = playerId,
                CityMapEntityId = cityMapEntityId,
            },
        };

        return GameApiClient.LoadAsync(world, payload);
    }

    public Task<string> LoadConstructionRankingAsync(GameWorldConfig world, int playerId, int cityMapEntityId,
        int lvlFrom, int lvlTo)
    {
        var payload = new List<ServerRequestBase>();
        for (var i = lvlFrom; i <= lvlTo; i++)
        {
            payload.Add(new GetConstructionRankingRequest
            {
                PlayerId = playerId,
                CityMapEntityId = cityMapEntityId,
                Level = i,
            });
        }

        return GameApiClient.LoadAsync(world, payload);
    }

    public Task<string> LoadContributionsAsync(GameWorldConfig world)
    {
        return GameApiClient.LoadAsync(world, [new GetContributionsRequest()]);
    }

    public static IReadOnlyCollection<IList<FJGreatBuildingRankingRow>> GetConstructionRankingResponse(
        IEnumerable<ServerResponse> data)
    {
        return data.FindAllAndConvert<IList<FJGreatBuildingRankingRow>>(REQUEST_CLASS,
            GetConstructionRankingRequest.METHOD);
    }

    public static IReadOnlyCollection<FJGreatBuildingConstruction> GetConstructionResponse(
        IEnumerable<ServerResponse> data)
    {
        return data.FindAllAndConvert<FJGreatBuildingConstruction>(REQUEST_CLASS, GetConstructionRequest.METHOD);
    }

    public class GetConstructionRankingRequest() : ServerRequestBase(REQUEST_CLASS, METHOD)
    {
        public const string METHOD = "getConstructionRanking";

        [JsonIgnore]
        public required int CityMapEntityId { get; init; }

        [JsonIgnore]
        public required int Level { get; init; }

        [JsonIgnore]
        public required int PlayerId { get; init; }

        protected override object?[] GetRequestData()
        {
            return [CityMapEntityId, PlayerId, Level];
        }
    }

    public class GetConstructionRequest() : ServerRequestBase(REQUEST_CLASS, METHOD)
    {
        public const string METHOD = "getConstruction";

        [JsonIgnore]
        public required int CityMapEntityId { get; init; }

        [JsonIgnore]
        public required int PlayerId { get; init; }

        protected override object?[] GetRequestData()
        {
            return [CityMapEntityId, PlayerId];
        }
    }

    public class GetContributionsRequest() : ServerRequestBase(REQUEST_CLASS, METHOD)
    {
        public const string METHOD = "getContributions";
    }
}

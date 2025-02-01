using Ingweland.Fog.Inn.Models.Core;
using Ingweland.Fog.Inn.Models.Foe;
using Ingweland.Fog.Inn.Sdk.Authentication.Model;
using Ingweland.Fog.Inn.Sdk.Extensions;
using Ingweland.Fog.Inn.Sdk.Models.Abstractions;
using Ingweland.Fog.Inn.Sdk.Net.Abstractions;
using Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Sdk.Services.Foe;

public class RankingService(IFoeApiClient gameApiClient) : GameServiceBase(gameApiClient), IRankingService
{
    private const double DEFAULT_PAGE_SIZE = 50d;
    private const int PAGES_PER_TURN = 6;
    private const string REQUEST_CLASS = "RankingService";

    public Task<IEnumerable<FJRankingList<FJBattlegroundClanGlobalRanking>>> GetClanRankingsAsync(GameWorldConfig world,
        int start, int amount)
    {
        return GetRankingsAsync<FJBattlegroundClanGlobalRanking>(world, FJRankingCategory.BattlegroundsClanGlobal,
            start, amount);
    }

    public Task<IEnumerable<FJRankingList<FJGreatBuildingRanking>>> GetGreatBuildingRankingsAsync(GameWorldConfig world,
        int start, int amount)
    {
        return GetRankingsAsync<FJGreatBuildingRanking>(world, FJRankingCategory.GreatBuilding, start, amount);
    }

    public Task<IEnumerable<FJRankingList<FJRanking>>> GetMedalRankingsAsync(GameWorldConfig world, int start,
        int amount)
    {
        return GetRankingsAsync<FJRanking>(world, FJRankingCategory.Medals, start, amount);
    }

    public Task<IEnumerable<FJRankingList<FJRanking>>> GetPlayerRankingsAsync(GameWorldConfig world, int start,
        int amount)
    {
        return GetRankingsAsync<FJRanking>(world, FJRankingCategory.Players, start, amount);
    }

    public Task<IEnumerable<FJRankingList<FJRanking>>> GetPvPArenaRankingsAsync(GameWorldConfig world, int start,
        int amount)
    {
        return GetRankingsAsync<FJRanking>(world, FJRankingCategory.Arena, start, amount);
    }

    public async Task<IEnumerable<FJRankingList<T>>> GetRankingsAsync<T>(GameWorldConfig world,
        FJRankingCategory rankingCategory, int start, int amount)
    {
        var rankings = new List<FJRankingList<T>>();
        var totalPages = (int)Math.Ceiling(Math.Max(amount, DEFAULT_PAGE_SIZE) / DEFAULT_PAGE_SIZE);
        var rnd = new Random();
        for (var i = 0; i < totalPages; i += PAGES_PER_TURN)
        {
            var payload = new List<ServerRequestBase>();
            for (var j = 0; j < Math.Min(PAGES_PER_TURN, totalPages - i); j++)
            {
                payload.Add(new GetRankingRequest
                {
                    Category = rankingCategory,
                    Page = start + i + j,
                });
            }

            var response = await GameApiClient.SendAsync(world, payload);

            rankings.AddRange(GetRankingResponse<T>(response));
            if (i > 0)
            {
                await Task.Delay(rnd.Next(1000, 2000));
            }
        }

        return rankings;
    }

    public IAsyncEnumerable<string> LoadGreatBuildingRankingsAsync(GameWorldConfig world, int start, int amount)
    {
        return LoadRankingsAsync(world, FJRankingCategory.GreatBuilding, start, amount);
    }

    public async IAsyncEnumerable<string> LoadRankingsAsync(GameWorldConfig world, FJRankingCategory rankingCategory,
        int start, int amount)
    {
        var totalPages = (int)Math.Ceiling(Math.Max(amount, DEFAULT_PAGE_SIZE) / DEFAULT_PAGE_SIZE);
        var rnd = new Random();
        for (var i = 0; i < totalPages; i += PAGES_PER_TURN)
        {
            var payload = new List<ServerRequestBase>();
            for (var j = 0; j < Math.Min(PAGES_PER_TURN, totalPages - i); j++)
            {
                payload.Add(new GetRankingRequest
                {
                    Category = rankingCategory,
                    Page = start + i + j,
                });
            }

            yield return await GameApiClient.LoadAsync(world, payload);

            if (i > 0)
            {
                await Task.Delay(rnd.Next(1000, 2000));
            }
        }
    }

    public static IEnumerable<FJRankingList<T>> GetRankingResponse<T>(IEnumerable<ServerResponse> data)
    {
        return data.FindAllAndConvert<FJRankingList<T>>(REQUEST_CLASS, GetRankingRequest.METHOD);
    }

    public class GetRankingRequest() : ServerRequestBase(REQUEST_CLASS, METHOD)
    {
        public const string METHOD = "getRanking";

        [JsonIgnore]
        public required FJRankingCategory Category { get; init; }

        [JsonIgnore]
        public int Page { get; init; }

        protected override object?[] GetRequestData()
        {
            return [Category, null, Page];
        }
    }
}

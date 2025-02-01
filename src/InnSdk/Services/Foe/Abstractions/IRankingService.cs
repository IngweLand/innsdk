using Ingweland.Fog.Inn.Models.Foe;
using Ingweland.Fog.Inn.Sdk.Authentication.Model;

namespace Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;

public interface IRankingService
{
    Task<IEnumerable<FJRankingList<FJBattlegroundClanGlobalRanking>>> GetClanRankingsAsync(GameWorldConfig world,
        int start, int amount);

    Task<IEnumerable<FJRankingList<FJGreatBuildingRanking>>> GetGreatBuildingRankingsAsync(GameWorldConfig world,
        int start, int amount);

    Task<IEnumerable<FJRankingList<FJRanking>>> GetMedalRankingsAsync(GameWorldConfig world, int start, int amount);

    Task<IEnumerable<FJRankingList<FJRanking>>> GetPlayerRankingsAsync(GameWorldConfig world, int start, int amount);

    Task<IEnumerable<FJRankingList<FJRanking>>> GetPvPArenaRankingsAsync(GameWorldConfig world, int start, int amount);

    Task<IEnumerable<FJRankingList<T>>> GetRankingsAsync<T>(GameWorldConfig world, FJRankingCategory rankingCategory,
        int start, int amount);

    IAsyncEnumerable<string> LoadGreatBuildingRankingsAsync(GameWorldConfig world, int start, int amount);

    IAsyncEnumerable<string> LoadRankingsAsync(GameWorldConfig world, FJRankingCategory rankingCategory, int start,
        int amount);
}

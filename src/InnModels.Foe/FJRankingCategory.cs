using Ingweland.Fog.Inn.Models.Foe.Converters;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

[JsonConverter(typeof(FJRankingCategoryConverter))]
public enum FJRankingCategory
{
    ClanBattleClanGlobal,
    ClanBattleClanProvince,
    BattlegroundsClanGlobal,
    GuildRaids,
    Players,
    Medals,
    GreatBuilding,
    Arena,
}

public static class FJRankingCategoryInfo
{
    public static string GetLabel(this FJRankingCategory source)
    {
        return source switch
        {
            FJRankingCategory.ClanBattleClanGlobal => "clan_battle_clan_global",
            FJRankingCategory.ClanBattleClanProvince => "clan_battle_clan_province",
            FJRankingCategory.BattlegroundsClanGlobal => "battlegrounds_clan_global",
            FJRankingCategory.GuildRaids => "guild_raids",
            FJRankingCategory.Players => "players",
            FJRankingCategory.Medals => "medals",
            FJRankingCategory.GreatBuilding => "great_building",
            FJRankingCategory.Arena => "arena",
            _ => throw new ArgumentException($"Label for {source} is not defined"),
        };
    }
}

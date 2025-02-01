using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJGreatBuildingContributionRow
{
    [JsonProperty("city_entity_id")]
    public string CityEntityId { get; set; }

    [JsonProperty("current_progress")]
    public int CurrentProgress { get; set; }

    [JsonProperty("entity_id")]
    public int EntityId { get; set; }

    [JsonProperty("forge_points")]
    public int ForgePoints { get; set; }

    [JsonProperty("last_spent")]
    public long LastSpent { get; set; }

    [JsonProperty("level")]
    public int Level { get; set; }

    [JsonProperty("max_progress")]
    public int MaxProgress { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("player")]
    public FJPlayer Player { get; set; }

    [JsonProperty("rank")]
    public int Rank { get; set; }

    [JsonProperty("reward")]
    public FJGreatBuildingRankingRowReward Reward { get; set; }
}

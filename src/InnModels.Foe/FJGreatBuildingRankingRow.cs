using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJGreatBuildingRankingRow
{
    [JsonProperty("forge_points")]
    public int ForgePoints { get; set; }

    [JsonProperty("player")]
    public FJOtherPlayer Player { get; set; }

    [JsonProperty("rank")]
    public short Rank { get; set; }

    [JsonProperty("reward")]
    public FJGreatBuildingRankingRowReward Reward { get; set; }
}

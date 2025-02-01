using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJGenericChestReward
{
    [JsonProperty("drop_chance")]
    public int DropChance { get; set; }

    [JsonProperty("reward")]
    public FJGenericReward Reward { get; set; }
}

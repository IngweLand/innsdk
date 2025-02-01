using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJGenericChest : FJGenericReward
{
    [JsonProperty("possible_rewards")]
    public IList<FJGenericChestReward> PossibleRewards { get; set; }
}

using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJRandomChestRewardAbility : FJAbilityBase
{
    [JsonProperty("rewards")]
    public Dictionary<string, FJGenericChest> Rewards { get; set; }
}

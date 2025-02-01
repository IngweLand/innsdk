using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJHiddenRewardOverview
{
    [JsonProperty("hiddenRewards")]
    public List<FJHiddenReward> HiddenRewards { get; set; }
}

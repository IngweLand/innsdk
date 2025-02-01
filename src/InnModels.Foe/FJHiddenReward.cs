using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJHiddenReward
{
    [JsonProperty("expireTime")]
    public long ExpireTime { get; set; }

    [JsonProperty("hiddenRewardId")]
    public long HiddenRewardId { get; set; }

    [JsonProperty("startTime")]
    public long StartTime { get; set; }
}

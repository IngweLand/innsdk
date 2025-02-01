using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCampaignSectorReward
{
    [JsonProperty("amount")]
    public int Amount { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }
}

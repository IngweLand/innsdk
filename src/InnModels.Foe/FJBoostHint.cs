using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJBoostHint
{
    [JsonProperty("targetedFeature")]
    public string TargetedFeature { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("value")]
    public int Value { get; set; }
}

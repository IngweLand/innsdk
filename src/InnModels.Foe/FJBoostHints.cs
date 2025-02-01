using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJBoostHints
{
    [JsonProperty("boostHintEraMap")]
    public Dictionary<string, FJBoostHint> BoostHintEraMap { get; set; }
}

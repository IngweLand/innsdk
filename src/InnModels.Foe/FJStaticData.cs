using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJStaticData
{
    [JsonProperty("identifier")]
    public string Identifier { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }
}

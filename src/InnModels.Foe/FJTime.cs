using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJTime
{
    [JsonProperty("time")]
    public int Value { get; set; }
}

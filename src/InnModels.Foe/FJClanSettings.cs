using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJClanSettings
{
    [JsonProperty("join")]
    public string Join { get; set; }
}

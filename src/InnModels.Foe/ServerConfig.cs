using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class ServerConfig
{
    [JsonProperty("flag")]
    public string Flag { get; set; }

    [JsonProperty("hiddenOnMobile")]
    public bool HiddenOnMobile { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("internal")]
    public bool Internal { get; set; }

    [JsonProperty("internalUrl")]
    public string InternalUrl { get; set; }

    [JsonProperty("isBeta")]
    public bool IsBeta { get; set; }

    [JsonProperty("isReference")]
    public bool IsReference { get; set; }

    [JsonProperty("lang")]
    public string Lang { get; set; }

    [JsonProperty("testMarket")]
    public bool TestMarket { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("version")]
    public Version Version { get; set; }
}

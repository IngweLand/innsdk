using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class Servers
{
    [JsonProperty("markets")]
    public Dictionary<string, ServerConfig> Markets { get; set; }
}

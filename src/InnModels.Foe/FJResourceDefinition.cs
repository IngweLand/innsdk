using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJResourceDefinition
{
    [JsonProperty("era")]
    public string Era { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("namePlural")]
    public string NamePlural { get; set; }

    [JsonProperty("nameSingular")]
    public string NameSingular { get; set; }
}

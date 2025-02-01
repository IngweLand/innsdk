using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJAffectsEnvironmentAbility
{
    [JsonProperty("trigger")]
    public string Trigger { get; set; }
}

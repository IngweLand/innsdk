using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJOffGridBuildingAbility : FJAbilityBase
{
    [JsonProperty("context")]
    public string Context { get; set; }
}

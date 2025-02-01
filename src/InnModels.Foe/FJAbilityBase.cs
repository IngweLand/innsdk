using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public abstract class FJAbilityBase
{
    [JsonProperty("__class__")]
    public string Clazz { get; set; }
}

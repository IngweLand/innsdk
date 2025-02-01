using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityEntityStreet : FJCityEntity
{
    [JsonProperty("provided_happiness")]
    public int ProvidedHappiness { get; set; }
}

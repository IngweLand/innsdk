using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityEntityCultureBuilding : FJCityEntity
{
    [JsonProperty("provided_happiness")]
    public int ProvidedHappiness { get; set; }
}

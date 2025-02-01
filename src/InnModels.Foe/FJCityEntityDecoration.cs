using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityEntityDecoration : FJCityEntity
{
    [JsonProperty("provided_happiness")]
    public int ProvidedHappiness { get; set; }
}

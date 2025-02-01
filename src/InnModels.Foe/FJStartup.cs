using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJStartup
{
    [JsonProperty("city_map")]
    public FJCityMap CityMap { get; set; }
}

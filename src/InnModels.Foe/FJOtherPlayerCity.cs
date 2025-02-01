using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJOtherPlayerCity
{
    [JsonProperty("city_map")]
    public FJCityMap CityMap { get; set; }

    [JsonProperty("other_player")]
    public FJPlayer Player { get; set; }
}

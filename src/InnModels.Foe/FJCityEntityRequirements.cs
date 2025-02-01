using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityEntityRequirements
{
    [JsonProperty("cost")]
    public FJResources Cost { get; set; }

    [JsonProperty("min_era")]
    public string MinEra { get; set; }

    [JsonProperty("street_connection_level")]
    public int StreetConnectionLevel { get; set; }

    [JsonProperty("tech_id")]
    public string TechId { get; set; }
}

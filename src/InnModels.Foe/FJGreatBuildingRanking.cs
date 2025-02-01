using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJGreatBuildingRanking : FJRanking
{
    [JsonProperty("cityEntityId")]
    [JsonPropertyName("cityEntityId")]
    public string CityEntityId { get; set; }

    [JsonProperty("entityId")]
    [JsonPropertyName("entityId")]
    public int EntityId { get; set; }

    [JsonProperty("era")]
    [JsonPropertyName("era")]
    public string Era { get; set; }

    [JsonProperty("level")]
    [JsonPropertyName("level")]
    public short Level { get; set; }

    [JsonProperty("name")]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonProperty("requiredPoints")]
    [JsonPropertyName("requiredPoints")]
    public int RequiredPoints { get; set; }
}

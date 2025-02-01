using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJRanking
{
    [JsonProperty("battles")]
    [JsonPropertyName("battles")]
    public int? Battles { get; set; }

    [JsonProperty("clan")]
    [JsonPropertyName("clan")]
    public FJClan Clan { get; set; }

    [JsonProperty("medals")]
    [JsonPropertyName("medals")]
    public long? Medals { get; set; }

    [JsonProperty("player")]
    [JsonPropertyName("player")]
    public FJPlayer Player { get; set; }

    [JsonProperty("points")]
    [JsonPropertyName("points")]
    public long? Points { get; set; }

    [Newtonsoft.Json.JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public string PropertiesHash { get; set; }

    [JsonProperty("rank")]
    [JsonPropertyName("rank")]
    public int Rank { get; set; }
}

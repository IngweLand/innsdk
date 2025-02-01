using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJEntityLevel : FJEntityLevelBase
{
    [JsonProperty("points")]
    public int? Points { get; set; }

    [JsonProperty("provided_happiness")]
    public int? ProvidedHappiness { get; set; }

    [JsonProperty("ranking_points")]
    public int? RankingPoints { get; set; }
}

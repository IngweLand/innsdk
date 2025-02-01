using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJRankingList<T>
{
    [JsonProperty("category")]
    public FJRankingCategory Category { get; set; }

    [JsonProperty("length")]
    public int Length { get; set; }

    [JsonProperty("page")]
    public int Page { get; set; }

    [JsonProperty("rankings")]
    public List<T> Rankings { get; set; }

    [JsonProperty("search_successful")]
    public bool SearchSuccessful { get; set; }
}

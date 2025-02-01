using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityGood
{
    [JsonProperty("good_id")]
    public string FoeOriginalGoodId { get; set; }

    [JsonProperty("value")]
    public int Value { get; set; }
}

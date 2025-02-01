using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJGreatBuildingBonus
{
    [JsonProperty("amount")]
    public float Amount { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("values")]
    public List<double> Values { get; set; }
}

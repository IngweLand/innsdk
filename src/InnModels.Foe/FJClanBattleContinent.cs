using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJClanBattleContinent
{
    [JsonProperty("bounds")]
    public FJBounds Bounds { get; set; }

    [JsonProperty("calculation_time")]
    public FJClanBattleCalculationTime CalculationTime { get; set; }

    [JsonProperty("provinces")]
    public List<FJClanBattleProvince> Provinces { get; set; }
}

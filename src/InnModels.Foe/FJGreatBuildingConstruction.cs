using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJGreatBuildingConstruction
{
    [JsonProperty("next_passive_bonus")]
    public FJGreatBuildingCityMapBonusBase NextPassiveBonus { get; set; }

    [JsonProperty("next_production_bonus")]
    public FJGreatBuildingCityMapBonusBase NextProductionBonus { get; set; }

    [JsonProperty("ownerEra")]
    public string OwnerEra { get; set; }

    [JsonProperty("rankings")]
    public List<FJGreatBuildingRankingRow> Rankings { get; set; }
}

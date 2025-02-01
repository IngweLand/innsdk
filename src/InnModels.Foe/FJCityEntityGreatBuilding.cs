using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityEntityGreatBuilding : FJCityEntity
{
    [JsonProperty("available_products")]
    public IList<FJCityEntityProductionProduct> AvailableProducts { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("passive_bonus")]
    public FJGreatBuildingBonus PassiveBonus { get; set; }

    [JsonProperty("production_bonus")]
    public FJGreatBuildingBonus ProductionBonus { get; set; }

    [JsonProperty("strategy_points_for_upgrade")]
    public List<short> StrategyPointsForUpgrade { get; set; }

    [JsonProperty("unlockLevelBaseCost")]
    public FJResources UnlockLevelBaseCost { get; set; }
}

using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityEntityResidentialBuilding : FJCityEntity
{
    [JsonProperty("available_products")]
    public IList<FJCityEntityProductionProduct> AvailableProducts { get; set; }

    [JsonProperty("demand_for_happiness")]
    public int? DemandForHappiness { get; set; }
}

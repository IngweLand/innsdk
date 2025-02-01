using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityEntityClanPowerProductionBuilding : FJCityEntity
{
    [JsonProperty("available_products")]
    public IList<FJCityEntityClanPowerProduct> AvailableProducts { get; set; }
}

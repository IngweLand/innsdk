using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityEntityCulturalGoodsBuilding : FJCityEntity
{
    [JsonProperty("available_products")]
    public IList<FJCityEntityResourcesWithRequirementsProduct> AvailableProducts { get; set; }
}

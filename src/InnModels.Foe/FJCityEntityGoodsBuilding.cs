using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityEntityGoodsBuilding : FJCityEntity
{
    [JsonProperty("available_products")]
    public IList<FJCityEntityGoodsProduct> AvailableProducts { get; set; }

    [JsonProperty("provided_happiness")]
    public int? ProvidedHappiness { get; set; }
}

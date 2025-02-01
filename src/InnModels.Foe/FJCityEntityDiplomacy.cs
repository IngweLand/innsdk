using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityEntityDiplomacy : FJCityEntity
{
    [JsonProperty("available_products")]
    public IList<FJCityEntityProductionProduct> AvailableProducts { get; set; }
}

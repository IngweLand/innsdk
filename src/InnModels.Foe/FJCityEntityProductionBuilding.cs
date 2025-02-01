using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityEntityProductionBuilding : FJCityEntity
{
    [JsonProperty("available_products")]
    public IList<FJCityEntityProductionProduct> AvailableProducts { get; set; }

    [JsonProperty("provided_happiness")]
    public int? ProvidedHappiness { get; set; }
}

using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityEntityProductionProduct : FJCityEntityProductBase
{
    [JsonProperty("product")]
    public FJResources Product { get; set; }
}

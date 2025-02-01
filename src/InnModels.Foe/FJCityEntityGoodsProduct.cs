using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityEntityGoodsProduct : FJCityEntityProductBase
{
    [JsonProperty("deposit_id")]
    public string DepositId { get; set; }

    [JsonProperty("product")]
    public FJResources Product { get; set; }

    [JsonProperty("requirements")]
    public FJCityEntityRequirements Requirements { get; set; }
}

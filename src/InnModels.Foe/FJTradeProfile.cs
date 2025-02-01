using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJTradeProfile
{
    [JsonProperty("needs")]
    public IList<FJCityGood> Needs { get; set; }

    [JsonProperty("offers")]
    public IList<object> Offers { get; set; }
}

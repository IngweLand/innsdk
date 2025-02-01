using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJBoostAbility
{
    [JsonProperty("boostHints")]
    public IList<FJBoostHints> BoostHints { get; set; }
}

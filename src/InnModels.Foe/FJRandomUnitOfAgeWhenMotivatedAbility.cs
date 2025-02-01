using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJRandomUnitOfAgeWhenMotivatedAbility : FJAbilityBase
{
    [JsonProperty("amount")]
    public int Amount { get; set; }
}

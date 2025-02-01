using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJChainLinkAbility
{
    [JsonProperty("bonuses")]
    public IList<FJCityEntityBonus> Bonuses { get; set; }

    [JsonProperty("bonusGiven")]
    public FJCityEntityBonus BonusGiven { get; set; }

    [JsonProperty("chainId")]
    public string ChainId { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("linkPositions")]
    public IList<FJChainLinkPosition> LinkPositions { get; set; }
}

using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJBonusOnSetAdjacencyAbility
{
    [JsonProperty("bonuses")]
    public IList<FJCityEntityBonus> Bonuses { get; set; }

    [JsonProperty("setId")]
    public string SetId { get; set; }
}

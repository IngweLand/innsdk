using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityEntityMilitaryBuilding : FJCityEntity
{
    [JsonProperty("available_products")]
    public IList<FJCityEntityMilitaryProduct> AvailableProducts { get; set; }

    [JsonProperty("passive_bonus")]
    public FJMilitaryUnitBonus PassiveBonus { get; set; }

    [JsonProperty("usable_slots")]
    public short UsableSlots { get; set; }
}

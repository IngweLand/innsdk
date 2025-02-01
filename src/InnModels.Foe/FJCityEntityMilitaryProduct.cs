using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityEntityMilitaryProduct : FJCityEntityProductBase
{
    [JsonProperty("amount")]
    public short Amount { get; set; }

    [JsonProperty("requirements")]
    public FJCityEntityRequirements Requirements { get; set; }

    [JsonProperty("time_to_heal")]
    public int TimeToHeal { get; set; }

    [JsonProperty("time_to_train")]
    public int TimeToTrain { get; set; }

    [JsonProperty("unit_class")]
    public string UnitClass { get; set; }

    [JsonProperty("unit_type_id")]
    public string UnitTypeId { get; set; }
}

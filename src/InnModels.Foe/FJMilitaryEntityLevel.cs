using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJMilitaryEntityLevel : FJEntityLevelBase
{
    [JsonProperty("unit_asset_name")]
    public string UnitAssetName { get; set; }

    [JsonProperty("unit_class")]
    public string UnitClass { get; set; }

    [JsonProperty("unit_id")]
    public string UnitId { get; set; }

    [JsonProperty("unit_name")]
    public string UnitName { get; set; }
}

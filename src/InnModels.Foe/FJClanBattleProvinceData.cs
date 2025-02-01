using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJClanBattleProvinceData
{
    [JsonProperty("province_detailed")]
    public FJClanBattleProvinceDetailed ProvinceDetailed { get; set; }
}

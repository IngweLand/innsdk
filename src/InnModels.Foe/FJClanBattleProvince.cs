using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJClanBattleProvince
{
    [JsonProperty("bounds")]
    public FJBounds Bounds { get; set; }

    [JsonProperty("clan_amount")]
    public short ClanAmount { get; set; }

    [JsonProperty("era")]
    public string Era { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("power_average")]
    public float PowerAverage { get; set; }

    [JsonProperty("sectors")]
    public List<FJClanBattleBaseSector> Sectors { get; set; }

    [JsonProperty("support_factor")]
    public float SupportFactor { get; set; }
}

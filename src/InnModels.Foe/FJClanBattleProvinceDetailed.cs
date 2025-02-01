using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJClanBattleProvinceDetailed
{
    [JsonProperty("bounds")]
    public FJBounds Bounds { get; set; }

    [JsonProperty("clan_amount")]
    public int ClanAmount { get; set; }

    [JsonProperty("era")]
    public string Era { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("power_average")]
    public float PowerAverage { get; set; }

    [JsonProperty("power_values")]
    public List<float> PowerValues { get; set; }

    [JsonProperty("sectors")]
    public List<FJClanBattleProvinceBaseSector> Sectors { get; set; }

    [JsonProperty("support_factor")]
    public float SupportFactor { get; set; }

//        public TYPE Unlock_defending_army_slot_resources { get; set; }

//        [JsonProperty("unlock_defending_army_slot_resources")]
//        public TYPE Clans { get; set; }

//        [JsonProperty("clans")]
}

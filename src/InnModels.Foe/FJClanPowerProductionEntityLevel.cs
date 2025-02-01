using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJClanPowerProductionEntityLevel : FJEntityLevelBase
{
    [JsonProperty("clan_power")]
    public int ClanPower { get; set; }
}

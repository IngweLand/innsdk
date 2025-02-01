using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJClanBattleContinentData
{
    [JsonProperty("continent")]
    public FJClanBattleContinent Continent { get; set; }
}

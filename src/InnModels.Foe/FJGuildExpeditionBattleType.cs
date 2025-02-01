using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJGuildExpeditionBattleType
{
    [JsonProperty("armyId")]
    public int ArmyId { get; set; }

    [JsonProperty("attackerPlayerId")]
    public int AttackerPlayerId { get; set; }

    [JsonProperty("__class__")]
    public string Clazz { get; set; }

    [JsonProperty("defenderPlayerId")]
    public int DefenderPlayerId { get; set; }

    [JsonProperty("encounterId")]
    public int EncounterId { get; set; }

    [JsonProperty("era")]
    public string Era { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }
}

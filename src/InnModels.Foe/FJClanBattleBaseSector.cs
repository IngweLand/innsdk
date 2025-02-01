using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJClanBattleBaseSector
{
    [JsonProperty("owner_id")]
    public int OwnerId { get; set; }

    [JsonProperty("position")]
    public FJPosition Position { get; set; }

    [JsonProperty("sector_id")]
    public int SectorId { get; set; }
}

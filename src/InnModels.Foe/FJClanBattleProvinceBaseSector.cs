using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJClanBattleProvinceBaseSector
{
    [JsonProperty("is_fogged")]
    public bool IsFogged { get; set; }

    [JsonProperty("owner_id")]
    public int OwnerId { get; set; }

    [JsonProperty("position")]
    public FJPosition Position { get; set; }

    [JsonProperty("power")]
    public float Power { get; set; }

    [JsonProperty("sector_id")]
    public int SectorId { get; set; }

    [JsonProperty("terrain")]
    public string Terrain { get; set; }
}

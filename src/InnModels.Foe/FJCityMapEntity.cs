using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityMapEntity
{
    [JsonProperty("bonus")]
    public FJGreatBuildingCityMapBonusBase Bonus { get; set; }

    [JsonProperty("cityentity_id")]
    public string CityEntityId { get; set; }

    [JsonProperty("connected")]
    public byte Connected { get; set; }

    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("level")]
    public short? Level { get; set; }

    [JsonProperty("max_level")]
    public short MaxLevel { get; set; }

    [JsonProperty("player_id")]
    public int? PlayerId { get; set; }

    [JsonProperty("state")]
    public FJCityMapEntityState State { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("x")]
    public short X { get; set; }

    [JsonProperty("y")]
    public short Y { get; set; }
}

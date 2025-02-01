using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJClan
{
    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("flag")]
    public string Flag { get; set; }

    [JsonProperty("flags_bought")]
    public object FlagsBought { get; set; }

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("level")]
    public short? Level { get; set; }

    [JsonProperty("level_configs")]
    public object LevelConfigs { get; set; }

    [JsonProperty("members")]
    public List<FJClanMember> Members { get; set; }

    [JsonProperty("membersNum")]
    public short? MembersNum { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("points")]
    public long? Points { get; set; }

    [JsonProperty("rank")]
    public int? Rank { get; set; }

    [JsonProperty("settings")]
    public FJClanSettings Settings { get; set; }
}

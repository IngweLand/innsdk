using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJClanMember : FJPlayer
{
    [JsonProperty("activity")]
    public sbyte? Activity { get; set; }

    [JsonIgnore]
    public override FJClan Clan { get; set; }

    [JsonProperty("permissions")]
    public object Permissions { get; set; }

    [JsonIgnore]
    public string PropertiesHash { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }
}

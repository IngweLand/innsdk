using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJFriend : FJPlayer
{
    [JsonProperty("accepted")]
    public bool Accepted { get; set; }
}

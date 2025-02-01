using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJRedirect
{
    [JsonProperty("message")]
    public string Message { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }
}

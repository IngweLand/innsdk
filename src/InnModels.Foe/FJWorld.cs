using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJWorld
{
    [JsonProperty("best")]
    public bool Best { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("login")]
    public bool Login { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("num_id")]
    public byte NumId { get; set; }

    [JsonProperty("rank")]
    public int Rank { get; set; }

    [JsonProperty("register")]
    public bool Register { get; set; }

    [JsonProperty("started_at")]
    public long StartedAt { get; set; }

    [JsonProperty("update")]
    public object Update { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("user_limit")]
    public int UserLimit { get; set; }
}

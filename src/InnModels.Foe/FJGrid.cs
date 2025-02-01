using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJGrid
{
    [JsonProperty("height")]
    public int Height { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("width")]
    public int Width { get; set; }

    [JsonProperty("x")]
    public int X { get; set; }

    [JsonProperty("y")]
    public int Y { get; set; }
}

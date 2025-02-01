using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityMapUnlockedArea
{
    [JsonProperty("__class__")]
    public string ClassIdentifier { get; set; }

    [JsonProperty("length")]
    public short Length { get; set; }

    [JsonProperty("width")]
    public short Width { get; set; }

    [JsonProperty("x")]
    public short X { get; set; }

    [JsonProperty("y")]
    public short Y { get; set; }
}

using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJBounds
{
    [JsonProperty("x_max")]
    public short XMax { get; set; }

    [JsonProperty("x_min")]
    public short XMin { get; set; }

    [JsonProperty("y_max")]
    public short YMax { get; set; }

    [JsonProperty("y_min")]
    public short YMin { get; set; }
}

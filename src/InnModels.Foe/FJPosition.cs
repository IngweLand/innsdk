using Ingweland.Fog.Inn.Models.Core;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJPosition : InnJsonObjectBase
{
    [JsonProperty("x")]
    public int X { get; set; }

    [JsonProperty("y")]
    public int Y { get; set; }
}

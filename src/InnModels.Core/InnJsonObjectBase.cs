using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Core;

public abstract class InnJsonObjectBase
{
    [JsonProperty("__class__")]
    public required string ClassIdentifier { get; set; }
}

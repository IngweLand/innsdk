using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Ingweland.Fog.Inn.Models.Core;

public class ServerResponse
{
    [JsonProperty("__class__")]
    public required string ClassIdentifier { get; set; }

    [JsonProperty("responseData")]
    public required JToken Data { get; set; }

    [JsonProperty("requestClass")]
    public required string RequestClass { get; set; }

    [JsonProperty("requestId")]
    public int RequestId { get; set; }

    [JsonProperty("requestMethod")]
    public required string RequestMethod { get; set; }
}

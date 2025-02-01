using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public record MobileAuthResponseBase
{
    [JsonProperty("status", Required = Required.Always)]
    public required string Status { get; init; }
}

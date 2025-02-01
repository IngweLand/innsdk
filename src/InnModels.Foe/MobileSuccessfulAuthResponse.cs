using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public record MobileSuccessfulAuthResponse : MobileAuthResponseCommon
{
    [JsonProperty("csrf")]
    public required string Csrf { get; init; }

    [JsonProperty("session_id")]
    public required string SessionId { get; init; }
}

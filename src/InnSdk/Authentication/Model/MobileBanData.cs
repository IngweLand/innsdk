using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Sdk.Authentication.Model;

public record MobileBanData
{
    [JsonProperty("reason")]
    public string Reason { get; init; }

    [JsonProperty("status")]
    public string Status { get; init; }

    [JsonProperty("unban_time")]
    public int UnbanTime { get; init; }
}

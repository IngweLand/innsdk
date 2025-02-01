using Ingweland.Fog.Inn.Models.Foe;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Sdk.Authentication.Model;

public record MobileBanLoginResponse : MobileAuthResponseBase
{
    [JsonProperty("data")]
    public required MobileBanData Data { get; init; }
}

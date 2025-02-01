using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public record WebLoginErrorInfo(
    [JsonProperty("message")] string Message,
    [JsonProperty("code")] string Code,
    [JsonProperty("offer_support")] bool OfferSupport);

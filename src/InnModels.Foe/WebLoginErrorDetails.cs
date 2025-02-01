using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public record WebLoginErrorDetails([JsonProperty("error")] WebLoginErrorInfo Error);

using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public record GameWorldLoginPayload([JsonProperty("login_url")] string LoginUrl);

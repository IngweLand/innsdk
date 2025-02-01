using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJConversation
{
    [JsonProperty("messages")]
    public List<FJConversationPlayerMessage> Messages { get; set; }
}

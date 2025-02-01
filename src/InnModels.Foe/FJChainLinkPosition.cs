using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJChainLinkPosition
{
    [JsonProperty("bottomRightPoint")]
    public FJPosition BottomRightPoint { get; set; }

    [JsonProperty("topLeftPoint")]
    public FJPosition TopLeftPoint { get; set; }
}

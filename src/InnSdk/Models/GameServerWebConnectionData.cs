namespace Ingweland.Fog.Inn.Sdk.Models;

[Obsolete]
public class GameServerWebConnectionData : GameServerConnectionData
{
    public required string Basepath { get; set; }
    public required string GameEngineUrl { get; set; }
    public required string LangHash { get; set; }
    public required string Locale { get; set; }
}

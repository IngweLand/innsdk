using Ingweland.Fog.Inn.Models.Core;

namespace Ingweland.Fog.Inn.Sdk.Models;

[Obsolete]
public class GameServerConfig
{
    public string Email { get; }
    public OriginalGame Game { get; set; }
    public string Id => ServerDomain + WorldNumber;
    public string Password { get; set; }
    public string ServerDomain { get; set; }

    public string SignatureSecret { get; set; }
    public string Timezone { get; set; }
    public string Username { get; set; }
    public byte WorldNumber { get; set; }
}

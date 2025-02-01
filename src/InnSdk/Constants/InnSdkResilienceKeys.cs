using Ingweland.Fog.Inn.Sdk.Authentication.Model;
using Polly;

namespace Ingweland.Fog.Inn.Sdk.Constants;

public static class InnSdkResilienceKeys
{
    public static readonly ResiliencePropertyKey<GameWorldCredentials> GameServerCredentials =
        new("game-server-credentials");
}

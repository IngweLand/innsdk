using Ingweland.Fog.Inn.Sdk.Models;

namespace Ingweland.Fog.Inn.Sdk.Authentication.Abstractions;

public interface IFoeWebAuthenticationResponseHandler
{
    void CheckAuthentication(string? response);
    GameServerWebConnectionData CreateConnectionData(string? response);
    string GetLoginUrl(string? response);
}

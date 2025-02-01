using Ingweland.Fog.Inn.Sdk.Authentication.Model;
using Ingweland.Fog.Inn.Sdk.Models;

namespace Ingweland.Fog.Inn.Sdk.Authentication.Abstractions;

public interface IFoeWebAuthenticationService
{
    Task<GameServerWebConnectionData> Authenticate(GameWorldConfig world);
}

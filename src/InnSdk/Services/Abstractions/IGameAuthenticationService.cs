using Ingweland.Fog.Inn.Sdk.Authentication.Model;

namespace Ingweland.Fog.Inn.Sdk.Services.Abstractions;

public interface IGameAuthenticationService
{
    Task Authenticate(GameWorldConfig world);
}

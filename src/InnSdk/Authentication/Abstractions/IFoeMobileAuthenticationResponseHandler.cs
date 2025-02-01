using Ingweland.Fog.Inn.Sdk.Models;

namespace Ingweland.Fog.Inn.Sdk.Authentication.Abstractions;

public interface IFoeMobileAuthenticationResponseHandler
{
    GameConnectionSessionData HandleResponse(string? response);
}

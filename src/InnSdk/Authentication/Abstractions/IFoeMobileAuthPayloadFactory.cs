using Ingweland.Fog.Inn.Sdk.Authentication.Model;

namespace Ingweland.Fog.Inn.Sdk.Authentication.Abstractions;

public interface IFoeMobileAuthPayloadFactory
{
    FormUrlEncodedContent Create(GameWorldCredentials credentials);
}

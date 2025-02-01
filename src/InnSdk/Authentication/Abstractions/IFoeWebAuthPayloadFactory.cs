using Ingweland.Fog.Inn.Sdk.Authentication.Model;

namespace Ingweland.Fog.Inn.Sdk.Authentication.Abstractions;

public interface IFoeWebAuthPayloadFactory
{
    FormUrlEncodedContent CreateForStep1(GameWorldCredentials credentials);
    FormUrlEncodedContent CreateForStep2(string worldId);
}

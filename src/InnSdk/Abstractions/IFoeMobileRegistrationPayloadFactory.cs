namespace Ingweland.Fog.Inn.Sdk.Abstractions;

public interface IFoeMobileRegistrationPayloadFactory
{
    FormUrlEncodedContent Create(string password);
}

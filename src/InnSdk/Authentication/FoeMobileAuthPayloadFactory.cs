using Ingweland.Fog.Inn.Sdk.Authentication.Abstractions;
using Ingweland.Fog.Inn.Sdk.Authentication.Model;

namespace Ingweland.Fog.Inn.Sdk.Authentication;

public class FoeMobileAuthPayloadFactory : IFoeMobileAuthPayloadFactory
{
    public FormUrlEncodedContent Create(GameWorldCredentials credentials)
    {
        return new FormUrlEncodedContent(new Dictionary<string, string>
        {
            {"auto", "false"},
            {"name", credentials.Username},
            {"password", credentials.Password},
            {"world_id", credentials.WorldId},
        });
    }
}

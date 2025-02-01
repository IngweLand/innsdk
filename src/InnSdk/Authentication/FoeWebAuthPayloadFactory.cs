using Ingweland.Fog.Inn.Sdk.Authentication.Abstractions;
using Ingweland.Fog.Inn.Sdk.Authentication.Model;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Sdk.Authentication;

public class FoeWebAuthPayloadFactory : IFoeWebAuthPayloadFactory
{
    public FormUrlEncodedContent CreateForStep1(GameWorldCredentials credentials)
    {
        return new FormUrlEncodedContent(new Dictionary<string, string>
        {
            {"login[remember_me]", "true"},
            {"login[userid]", credentials.Username},
            {"login[password]", credentials.Password},
        });
    }

    public FormUrlEncodedContent CreateForStep2(string worldId)
    {
        var o = new Dictionary<string, object>
        {
            {"world_id", worldId},
        };
        var payload = JsonConvert.SerializeObject(o);
        return new FormUrlEncodedContent(new Dictionary<string, string>
        {
            {"json", payload},
        });
    }
}

using Ingweland.Fog.Inn.Models.Foe;
using Ingweland.Fog.Inn.Sdk.Authentication;
using Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Sdk.Services.Foe;

public class FoeMobilePreloginResponseHandler() : IFoeMobilePreloginResponseHandler
{
    public MobilePreloginResponse HandleResponse(string? response)
    {
        if (string.IsNullOrWhiteSpace(response))
        {
            throw new AuthenticationException(AuthErrorCode.EmptyResponse);
        }

        if (response.Contains("AuthenticationError"))
        {
            throw new AuthenticationException(AuthErrorCode.None, response);
        }

        MobilePreloginResponse baseResponse;
        try
        {
            return JsonConvert.DeserializeObject<MobilePreloginResponse>(response)!;
        }
        catch (Exception e)
        {
            throw new AuthenticationException(AuthErrorCode.UnknownResponseFormat, response, e);
        }
    }
}

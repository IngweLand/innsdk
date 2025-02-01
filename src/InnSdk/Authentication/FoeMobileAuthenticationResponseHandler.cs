using Ingweland.Fog.Inn.Models.Foe;
using Ingweland.Fog.Inn.Sdk.Authentication.Abstractions;
using Ingweland.Fog.Inn.Sdk.Models;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Sdk.Authentication;

public class FoeMobileAuthenticationResponseHandler() : IFoeMobileAuthenticationResponseHandler
{
    public GameConnectionSessionData HandleResponse(string? response)
    {
        if (string.IsNullOrWhiteSpace(response))
        {
            throw new AuthenticationException(AuthErrorCode.EmptyResponse);
        }

        MobileAuthResponseBase baseResponse;
        try
        {
            baseResponse = JsonConvert.DeserializeObject<MobileAuthResponseBase>(response)!;
        }
        catch (Exception e)
        {
            // TODO Handle AuthErrors like this
            // {"error":"This world is currently being updated. This takes only a few minutes. Please try again later.","__class__":"AuthenticationError"}
            throw new AuthenticationException(AuthErrorCode.UnknownResponseFormat, response, e);
        }

        switch (baseResponse.Status)
        {
            case AuthStatus.LOGIN:
            {
                MobileSuccessfulAuthResponse? loginResponse;
                try
                {
                    loginResponse = JsonConvert.DeserializeObject<MobileSuccessfulAuthResponse>(response);
                }
                catch (Exception e)
                {
                    throw new AuthenticationException(AuthErrorCode.UnknownResponseFormat, response, e);
                }

                return new GameConnectionSessionData(WorldId: loginResponse!.WorldId, CsrfToken: loginResponse.Csrf,
                    SessionId: loginResponse.SessionId);
            }

            case AuthStatus.BAN:
            {
                throw new AuthenticationException(AuthErrorCode.UserBanned);
            }
            default:
            {
                throw new AuthenticationException(AuthErrorCode.UnknownResponseStatus, response);
            }
        }
    }
}

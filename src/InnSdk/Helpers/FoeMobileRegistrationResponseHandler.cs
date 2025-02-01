using Ingweland.Fog.Inn.Models.Foe;
using Ingweland.Fog.Inn.Sdk.Constants;
using Ingweland.Fog.Inn.Sdk.Exceptions;
using Ingweland.Fog.Inn.Sdk.Helpers.Abstractions;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Sdk.Helpers;

public class FoeMobileRegistrationResponseHandler : IFoeMobileRegistrationResponseHandler
{
    public MobileSuccessfulRegistrationResponse HandleResponse(string? response)
    {
        if (string.IsNullOrWhiteSpace(response))
        {
            throw new RegistrationException(RegistrationErrorCode.EmptyResponse);
        }

        MobileAuthResponseBase baseResponse;
        try
        {
            baseResponse = JsonConvert.DeserializeObject<MobileAuthResponseBase>(response)!;
        }
        catch (Exception e)
        {
            throw new RegistrationException(RegistrationErrorCode.UnknownResponseFormat, response, e);
        }

        switch (baseResponse.Status)
        {
            case FoeRegistrationStatus.LOGIN:
            {
                MobileSuccessfulRegistrationResponse? registrationResponse;
                try
                {
                    registrationResponse =
                        JsonConvert.DeserializeObject<MobileSuccessfulRegistrationResponse>(response);
                }
                catch (Exception e)
                {
                    throw new RegistrationException(RegistrationErrorCode.UnknownResponseFormat, response, e);
                }

                if (registrationResponse == null)
                {
                    throw new RegistrationException(RegistrationErrorCode.UnknownResponseFormat, response);
                }

                return registrationResponse;
            }

            default:
            {
                throw new RegistrationException(RegistrationErrorCode.UnknownResponseStatus, baseResponse.Status);
            }
        }
    }
}

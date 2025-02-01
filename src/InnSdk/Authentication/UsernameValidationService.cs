using Ingweland.Fog.Inn.Sdk.Authentication.Abstractions;
using Ingweland.Fog.Inn.Sdk.Constants;
using Ingweland.Fog.Inn.Sdk.Exceptions;
using Ingweland.Fog.Inn.Sdk.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Ingweland.Fog.Inn.Sdk.Authentication;

public class UsernameValidationService : FoeWebsiteServiceBase, IUsernameValidationService
{
    public async Task ValidateAsync(string username, string server)
    {
        await LoadStartPage(UrlBuilder.BuildBaseUrl(server));
        await DoValidateAsync(username, server);
    }

    private async Task DoValidateAsync(string username, string server)
    {
        var payload = new Dictionary<string, string>
        {
            {"registration[nickname]", username},
            {"registration[password]", "Password123!"},
            {"registration[acceptTerms]", "1"},
            {"registration[accepted3rdPartyPixels]", "1"},
        };
        var content = new FormUrlEncodedContent(payload);
        var url = string.Format(Urls.SERVER_URL_BASE, server) + Urls.VALIDATION;
        var responseMessage =
            await RetryPipeline.ExecuteAsync(async ct => await HttpClient.PostAsync(url, content, ct));
        var response = await responseMessage.Content.ReadAsStringAsync();
        try
        {
            var result = JsonConvert.DeserializeObject<JToken>(response);
            if (!result!.Value<bool>("success"))
            {
                throw new UsernameValidationException("Username taken");
            }
        }
        catch (Exception e)
        {
            throw new UsernameValidationException("Validation result data has wrong format", e);
        }
    }
}

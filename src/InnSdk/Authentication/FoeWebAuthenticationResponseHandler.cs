using System.Text.RegularExpressions;
using Ingweland.Fog.Inn.Models.Foe;
using Ingweland.Fog.Inn.Sdk.Authentication.Abstractions;
using Ingweland.Fog.Inn.Sdk.Models;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Sdk.Authentication;

public partial class FoeWebAuthenticationResponseHandler() : IFoeWebAuthenticationResponseHandler
{
    public void CheckAuthentication(string? response)
    {
        if (string.IsNullOrWhiteSpace(response))
        {
            throw new AuthenticationException(AuthErrorCode.EmptyResponse);
        }

        WebLoginResponse loginResponse;
        try
        {
            loginResponse = JsonConvert.DeserializeObject<WebLoginResponse>(response)!;
        }
        catch (Exception e)
        {
            throw new AuthenticationException(AuthErrorCode.UnknownResponseFormat, response, e);
        }

        if (!loginResponse.Success)
        {
            throw new AuthenticationException(AuthErrorCode.UnknownResponseStatus, response);
        }
    }

    public string GetLoginUrl(string? response)
    {
        if (string.IsNullOrWhiteSpace(response))
        {
            throw new AuthenticationException(AuthErrorCode.EmptyResponse);
        }

        try
        {
            var parsedPayload = JsonConvert.DeserializeObject<GameWorldLoginPayload>(response)!;
            if (!string.IsNullOrWhiteSpace(parsedPayload.LoginUrl))
            {
                return parsedPayload.LoginUrl;
            }

            throw new AuthenticationException(AuthErrorCode.LoginUrlNotFound, response);
        }
        catch (Exception e)
        {
            throw new AuthenticationException(AuthErrorCode.UnknownResponseFormat, response, e);
        }
    }

    public GameServerWebConnectionData CreateConnectionData(string? response)
    {
        if (string.IsNullOrWhiteSpace(response))
        {
            throw new AuthenticationException(AuthErrorCode.EmptyResponse);
        }

        try
        {
            var regex = GameVarsSectionRegex();
            var gameVarsSection = regex.Match(response);
            var stripped = WhitespaceRegex().Replace(gameVarsSection.Groups[1].Value, "");
            var gatewayUrlRegex = GatewayUrlRegex();
            var localeRegex = LocaleRegex();
            var langHashRegex = LangHashRegex();
            var baseUrlRegex = BaseUrlRegex();
            var gameEngineUrlRegex = GameEngineUrlRegex();
            var gatewayUrl = gatewayUrlRegex.Match(stripped).Groups[1].Value;
            var i = gatewayUrl.LastIndexOf("?h=", StringComparison.InvariantCulture) + 3;
            return new GameServerWebConnectionData
            {
                Basepath = baseUrlRegex.Match(stripped).Groups[1].Value,
                GameEngineUrl = gameEngineUrlRegex.Match(response).Groups[1].Value.Trim().Trim('\''),
                MainUrl = gatewayUrl,
                LangHash = langHashRegex.Match(response).Groups[1].Value,
                Locale = localeRegex.Match(stripped).Groups[1].Value,
                CsrfToken = gatewayUrl[i..],
            };
        }
        catch (Exception e)
        {
            throw new AuthenticationException(AuthErrorCode.UnknownResponseFormat, response, e);
        }
    }

    [GeneratedRegex(@"baseUrl:'([\s\S]*?)'")]
    private static partial Regex BaseUrlRegex();

    [GeneratedRegex(@"(?<=scriptref\.setAttribute\(\'src\',)(.*?)(?=\);)")]
    private static partial Regex GameEngineUrlRegex();

    [GeneratedRegex(@"var gameVars([\s\S]*?)\}")]
    private static partial Regex GameVarsSectionRegex();

    [GeneratedRegex(@"gatewayUrl:'([\s\S]*?)'")]
    private static partial Regex GatewayUrlRegex();

    [GeneratedRegex(@"client_lang-([\s\S]*?)\.mo")]
    private static partial Regex LangHashRegex();

    [GeneratedRegex(@"locale:'([\s\S]*?)'")]
    private static partial Regex LocaleRegex();

    [GeneratedRegex(@"\s+")]
    private static partial Regex WhitespaceRegex();
}

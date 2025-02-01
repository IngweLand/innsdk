using Ingweland.Fog.Inn.Sdk.Constants;

namespace Ingweland.Fog.Inn.Sdk.Helpers;

public static class UrlBuilder
{
    public static string BuildBaseUrl(string server)
    {
        return string.Format(Urls.SERVER_URL_BASE, server);
    }

    public static string BuildMainUrl(string worldId, string csrfToken)
    {
        return string.Format(Urls.MAIN_URL, worldId, csrfToken);
    }

    public static string BuildMobileRegistrationUrl(string server)
    {
        return string.Format(Urls.MOBILE_REGISTRATION, server);
    }

    public static string BuildWebPlayNowLoginUrl(string server)
    {
        return string.Format(Urls.PLAY_NOW_LOGIN_URL, server);
    }

    public static string BuildWebPreloginUrl(string server)
    {
        return $"{string.Format(Urls.SERVER_URL_BASE, server)}{Urls.WEB_PRE_LOGIN_URL}";
    }
}

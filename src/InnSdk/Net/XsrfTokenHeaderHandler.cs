namespace Ingweland.Fog.Inn.Sdk.Net;

public class XsrfTokenHeaderHandler(Func<HttpRequestMessage, string?> getHeaderValue) : DelegatingHandler
{
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        var headerValue = getHeaderValue(request);
        if (!string.IsNullOrEmpty(headerValue))
        {
            request.Headers.Add("X-XSRF-TOKEN", headerValue);
        }

        return base.SendAsync(request, cancellationToken);
    }
}

using System.Net;
using Ingweland.Fog.Inn.Sdk.Net;
using Polly;
using Polly.Retry;

namespace Ingweland.Fog.Inn.Sdk.Authentication;

public abstract class FoeWebsiteServiceBase
{
    private readonly RetryStrategyOptions<HttpResponseMessage> _retryStrategy = new()
    {
        ShouldHandle = new PredicateBuilder<HttpResponseMessage>().Handle<HttpRequestException>()
            .HandleResult(result => !result.IsSuccessStatusCode),
        BackoffType = DelayBackoffType.Exponential,
        MaxRetryAttempts = 3,
    };

    protected FoeWebsiteServiceBase()
    {
        CookieContainer = new CookieContainer();
        var baseHandler = new HttpClientHandler
        {
            AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
            CookieContainer = CookieContainer,
        };
        var xsrfTokenHeader = new XsrfTokenHeaderHandler(req =>
        {
            return CookieContainer.GetCookies(req.RequestUri!).FirstOrDefault(cookie => cookie.Name == "XSRF-TOKEN")
                ?.Value;
        })
        {
            InnerHandler = baseHandler,
        };
        HttpClient = new HttpClient(xsrfTokenHeader);
        HttpClient.DefaultRequestHeaders.Add("X-Requested-With", "XMLHttpRequest");
        RetryPipeline = new ResiliencePipelineBuilder<HttpResponseMessage>().AddRetry(_retryStrategy).Build();
    }

    protected CookieContainer CookieContainer { get; }

    protected HttpClient HttpClient { get; }

    protected ResiliencePipeline<HttpResponseMessage> RetryPipeline { get; }

    protected async Task LoadStartPage(string url)
    {
        await RetryPipeline.ExecuteAsync(async ct => await HttpClient.GetAsync(url, ct));
    }
}

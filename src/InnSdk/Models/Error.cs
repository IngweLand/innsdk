namespace Ingweland.Fog.Inn.Sdk.Models;

public class Error
{
    public bool IsReAuthenticationRequired { get; set; }
    public string Message { get; set; }
    public string RawData { get; set; }
}

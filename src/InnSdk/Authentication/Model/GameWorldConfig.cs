namespace Ingweland.Fog.Inn.Sdk.Authentication.Model;

public record GameWorldConfig(string Server, int Number)
{
    public string Id => $"{Server}{Number}";
}

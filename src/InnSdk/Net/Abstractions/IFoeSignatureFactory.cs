namespace Ingweland.Fog.Inn.Sdk.Net.Abstractions;

public interface IFoeSignatureFactory
{
    Task<string> CreateAsync(string data, string server, string csrfToken);
}

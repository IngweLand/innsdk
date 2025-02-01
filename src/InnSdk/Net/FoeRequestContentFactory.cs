using System.Net.Mime;
using System.Text;
using Ingweland.Fog.Inn.Sdk.Abstractions;
using Ingweland.Fog.Inn.Sdk.Authentication.Model;
using Ingweland.Fog.Inn.Sdk.Net.Abstractions;

namespace Ingweland.Fog.Inn.Sdk.Net;

public class FoeRequestContentFactory(IGameConnectionManager connectionManager, IFoeSignatureFactory signatureFactory)
    : IFoeRequestContentFactory
{
    public async Task<StringContent> CreateAsync(string payload, GameWorldConfig world)
    {
        var csrfToken = connectionManager.Get(world.Id)!.CsrfToken;
        var signature = await signatureFactory.CreateAsync(data: payload, server: world.Server, csrfToken: csrfToken);
        var content = new StringContent(payload, Encoding.UTF8, MediaTypeNames.Application.Json);
        content.Headers.Add("Signature", signature);
        content.Headers.Add("Cookie", $"sid={connectionManager.Get(world.Id)!.SessionId}");
        // content.Headers.Add("Client-identification", "version=1.290; requiredVersion=1.290");
        return content;
    }
}

using Ingweland.Fog.Inn.Sdk.Authentication.Model;

namespace Ingweland.Fog.Inn.Sdk.Net.Abstractions;

public interface IFoeRequestContentFactory
{
    Task<StringContent> CreateAsync(string payload, GameWorldConfig world);
}

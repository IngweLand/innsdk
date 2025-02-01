using Ingweland.Fog.Inn.Models.Foe;
using Ingweland.Fog.Inn.Sdk.Authentication.Model;

namespace Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;

public interface IStartupService
{
    Task<IReadOnlyCollection<FJStaticData>> GetMetadataAsync(GameWorldConfig world);
}

using Ingweland.Fog.Inn.Models.Core;

namespace Ingweland.Fog.Inn.Sdk.Authentication.Model;

public record GameWorldCredentials(OriginalGame Game, string WorldId, string Username, string Password);

using Ingweland.Fog.Inn.Models.Core;

namespace Ingweland.Fog.Inn.Sdk.Extensions;

public static class OriginalGameExtensions
{
    public static string ToCode(this OriginalGame source)
    {
        return source switch
        {
            OriginalGame.Foe => "foe",
            OriginalGame.Elv => "elv",
            _ => "undefined",
        };
    }

    public static string ToLabel(this OriginalGame source)
    {
        return source switch
        {
            OriginalGame.Foe => "Forge of Empires",
            OriginalGame.Elv => "Elvenar",
            _ => "Undefined",
        };
    }
}

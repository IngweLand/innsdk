using System.Reflection;
using Ingweland.Fog.Inn.Models.Core;

namespace Ingweland.Fog.Inn.Models.Foe.Helpers;

public class FoeEntityTypeFactory : InnGameEntityTypeFactoryBase
{
    public override Type GetType(string searchString, string fallbackSrc = null)
    {
        var t = base.GetType(searchString, fallbackSrc);
        if (t != null)
        {
            return t;
        }

        t = Assembly.GetExecutingAssembly().GetTypes()
            .SingleOrDefault(type => type.Name == $"FJ{searchString}");
        if (t == null && fallbackSrc != null)
        {
            t = Assembly.GetExecutingAssembly().GetTypes()
                .SingleOrDefault(type => type.Name == $"FJ{fallbackSrc}");
        }

        return t;
    }
}

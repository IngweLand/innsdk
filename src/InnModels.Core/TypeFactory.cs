using System.Reflection;
using Newtonsoft.Json.Linq;

namespace Ingweland.Fog.Inn.Models.Core;

public abstract class InnGameEntityTypeFactoryBase
{
    public object? Create(string src, string? fallbackSrc = null)
    {
        var t = GetType(src, fallbackSrc);
        object? result = null;
        if (t != null)
        {
            result = Activator.CreateInstance(t);
        }

        return result;
    }

    public object? Create(JTokenType src)
    {
        return src switch
        {
            JTokenType.Array => new List<object>(),
            JTokenType.Boolean => default(bool),
            JTokenType.Date => default(DateTimeOffset),
            JTokenType.Float => new double(),
            JTokenType.Integer => new long(),
            JTokenType.String => default(string),
            JTokenType.TimeSpan => new TimeSpan(),
            JTokenType.Uri => default(Uri),
            _ => new object(),
        };
    }

    public virtual Type? GetType(string searchString, string? fallbackSrc = null)
    {
        var t = Assembly.GetExecutingAssembly().GetTypes()
            .SingleOrDefault(type => type.Name == searchString);
        if (t == null && fallbackSrc != null)
        {
            t = Assembly.GetExecutingAssembly().GetTypes()
                .SingleOrDefault(type => type.Name == fallbackSrc);
        }

        return t;
    }
}

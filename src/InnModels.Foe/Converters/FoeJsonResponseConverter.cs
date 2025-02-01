using Ingweland.Fog.Inn.Models.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Ingweland.Fog.Inn.Models.Foe.Converters;

public class FoeJsonResponseConverter : JsonConverter
{
    private static Dictionary<string, Func<FoeJsonResponse>> _foeEntitiesToConstructorsMap =
        new()
        {
            {"ServerResponse", () => new FoeJsonResponse()},
            {"Error", () => new FoeJsonResponse {Response = new Error()}},
            {"Redirect", () => new FoeJsonResponse {Response = new FJRedirect()}},
        };

    public override bool CanWrite => false;

    public override bool CanConvert(Type objectType)
    {
        throw new NotSupportedException();
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
        JsonSerializer serializer)
    {
        var jObject = JObject.Load(reader);
        var target = Create(jObject);
        if (target != null)
        {
            if (target.Response == null)
            {
                target.Response = serializer.Deserialize(jObject.CreateReader(),
                    typeof(ServerResponse));
            }
            else
            {
                serializer.Populate(jObject.CreateReader(), target.Response);
            }
        }

        return target;
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        throw new NotSupportedException();
    }

    private FoeJsonResponse Create(JObject jObject)
    {
        var clazz = jObject.Value<string>("__class__");
        if (clazz != null)
        {
            if (_foeEntitiesToConstructorsMap.TryGetValue(clazz, out var value))
            {
                return value.Invoke();
            }
        }

        throw new ArgumentException($"Unrecognized entity: {clazz}");
    }
}

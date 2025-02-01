using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Ingweland.Fog.Inn.Models.Foe.Converters;

public class FoeJsonDictionaryConverter<TValue> : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return true;
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        var token = JToken.Load(reader);
        if (token.Type == JTokenType.Array)
        {
            return new Dictionary<string, TValue>();
        }

        var result = new Dictionary<string, TValue>();
        foreach (var t in token.Children<JProperty>())
        {
            var key = t.Name;
            if (key == "__class__")
            {
                continue;
            }

            result.Add(key, t.Value.ToObject<TValue>());
        }

        return result;
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        serializer.Serialize(writer, value);
    }
}

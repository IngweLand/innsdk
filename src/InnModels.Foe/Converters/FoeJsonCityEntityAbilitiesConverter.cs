using Ingweland.Fog.Inn.Models.Foe.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Ingweland.Fog.Inn.Models.Foe.Converters;

public class FoeJsonCityEntityAbilitiesConverter : JsonConverter<IList<object>>
{
    public override IList<object> ReadJson(JsonReader reader, Type objectType, IList<object> existingValue,
        bool hasExistingValue,
        JsonSerializer serializer)
    {
        var result = new List<object>();
        var array = JArray.Load(reader);
        foreach (var entity in array.OfType<JObject>())
        {
            var clazz = entity.Value<string>("__class__");
            if (string.IsNullOrWhiteSpace(clazz))
            {
                throw new JsonException($"Could not find __class__ property. Input: {entity}");
            }

            var factory = new FoeEntityTypeFactory();
            var ability = factory.Create(clazz);
            if (ability != null)
            {
                serializer.Populate(entity.CreateReader(), ability);
            }
            else
            {
                Console.Out.WriteLine($"Missing type for ability: {clazz}");
                continue;
            }

            result.Add(ability);
        }

        return result;
    }

    public override void WriteJson(JsonWriter writer, IList<object> value, JsonSerializer serializer)
    {
        throw new NotSupportedException();
    }
}

using Ingweland.Fog.Inn.Models.Foe.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Ingweland.Fog.Inn.Models.Foe.Converters;

public class FoeJsonCityEntitiesConverter : JsonConverter<FJCityEntity>
{
    public override FJCityEntity ReadJson(JsonReader reader, Type objectType,
        FJCityEntity existingValue,
        bool hasExistingValue, JsonSerializer serializer)
    {
        var entity = JObject.Load(reader);
        var clazz = entity.Value<string>("__class__");
        if (string.IsNullOrWhiteSpace(clazz))
        {
            throw new JsonException($"Could not find __class__ property. Input: {entity}");
        }

        var factory = new FoeEntityTypeFactory();
        if (factory.Create(clazz) is not FJCityEntity building)
        {
            throw new ArgumentException($"Unrecognized entity: {clazz}. Input: {entity}");
        }

        serializer.Populate(entity.CreateReader(), building);
        return building;
    }

    public override void WriteJson(JsonWriter writer, FJCityEntity value, JsonSerializer serializer)
    {
        throw new NotSupportedException();
    }
}

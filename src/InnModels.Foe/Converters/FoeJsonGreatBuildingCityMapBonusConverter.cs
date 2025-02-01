using Ingweland.Fog.Inn.Models.Foe.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Ingweland.Fog.Inn.Models.Foe.Converters;

public class FoeJsonGreatBuildingCityMapBonusConverter : JsonConverter<FJGreatBuildingCityMapBonusBase>
{
    public override FJGreatBuildingCityMapBonusBase ReadJson(JsonReader reader, Type objectType,
        FJGreatBuildingCityMapBonusBase existingValue,
        bool hasExistingValue, JsonSerializer serializer)
    {
        var entity = JObject.Load(reader);
        var clazz = entity.Value<string>("__class__");
        if (string.IsNullOrWhiteSpace(clazz))
        {
            throw new JsonException($"Could not find __class__ property. Input: {entity}");
        }

        var factory = new FoeEntityTypeFactory();
        if (factory.Create(clazz) is not FJGreatBuildingCityMapBonusBase entityLevel)
        {
            throw new ArgumentException($"Unrecognized entity: {clazz}. Input: {entity}");
        }

        serializer.Populate(entity.CreateReader(), entityLevel);

        return entityLevel;
    }

    public override void WriteJson(JsonWriter writer, FJGreatBuildingCityMapBonusBase value,
        JsonSerializer serializer)
    {
        throw new NotSupportedException();
    }
}

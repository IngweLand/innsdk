using Ingweland.Fog.Inn.Models.Foe.Converters;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

[JsonConverter(typeof(FoeJsonResponseConverter))]
public class FoeJsonResponse
{
    public dynamic Response { get; set; }
}

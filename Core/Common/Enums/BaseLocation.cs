using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Core.Common.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BaseLocation
    {
        Hatzerim,
        TelNof,
        RamatDavid,
        Nevatim,
        Ramon,
        Hatzor,
        Palmachim,
        Ovda
    }
}

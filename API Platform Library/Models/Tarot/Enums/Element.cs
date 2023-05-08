using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Platform_Library.Models.Tarot.Enums
{
    [Flags]
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Element
    {
        None = 0,
        Water = 1,
        Earth = 2,
        Fire = 4,
        Air = 8
    }
}

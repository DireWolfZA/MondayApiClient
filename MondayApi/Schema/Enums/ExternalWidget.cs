using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum ExternalWidget {
        [EnumMember(Value = "CHART")]
        Chart,
        [EnumMember(Value = "NUMBER")]
        Number,
        [EnumMember(Value = "BATTERY")]
        Battery,
        [EnumMember(Value = "CALENDAR")]
        Calendar
    }
}

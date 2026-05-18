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
        Calendar,
        [EnumMember(Value = "GANTT")]
        Gantt,
        [EnumMember(Value = "APP_FEATURE")]
        AppFeature,
        [EnumMember(Value = "LISTVIEW")]
        Listview
    }
}

using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum FirstDayOfTheWeek {
        [EnumMember(Value = "monday")]
        Monday,
        [EnumMember(Value = "sunday")]
        Sunday
    }
}

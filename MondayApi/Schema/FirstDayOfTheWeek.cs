using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum FirstDayOfTheWeek {
        [EnumMember(Value = "sunday")] Sunday,
        [EnumMember(Value = "monday")] Monday
    }
}

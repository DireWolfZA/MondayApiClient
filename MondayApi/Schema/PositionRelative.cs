using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum PositionRelative {
        [EnumMember(Value = "before_at")] BeforeAt,
        [EnumMember(Value = "after_at")] AfterAt
    }
}

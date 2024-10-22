using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum PositionRelative {
        [EnumMember(Value = "after_at")]
        AfterAt,
        [EnumMember(Value = "before_at")]
        BeforeAt
    }
}

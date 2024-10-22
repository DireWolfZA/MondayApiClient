using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum GroupAttributes {
        [EnumMember(Value = "color")]
        Color,
        [EnumMember(Value = "position")]
        Position,
        [EnumMember(Value = "relative_position_after")]
        RelativePositionAfter,
        [EnumMember(Value = "relative_position_before")]
        RelativePositionBefore,
        [EnumMember(Value = "title")]
        Title
    }
}

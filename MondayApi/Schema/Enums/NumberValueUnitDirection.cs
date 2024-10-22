using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum NumberValueUnitDirection {
        [EnumMember(Value = "left")]
        Left,
        [EnumMember(Value = "right")]
        Right
    }
}

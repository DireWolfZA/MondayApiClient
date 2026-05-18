using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum ColumnCapability {
        [EnumMember(Value = "CALCULATED")]
        Calculated,
        [EnumMember(Value = "VISIBILITY")]
        Visibility
    }
}

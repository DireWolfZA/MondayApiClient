using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum AggregateSelectElementType {
        [EnumMember(Value = "COLUMN")]
        Column,
        [EnumMember(Value = "FUNCTION")]
        Function
    }
}

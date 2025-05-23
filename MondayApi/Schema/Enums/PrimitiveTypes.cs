using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum PrimitiveTypes {
        [EnumMember(Value = "STRING")]
        String,
        [EnumMember(Value = "NUMBER")]
        Number,
        [EnumMember(Value = "FLOAT")]
        Float,
        [EnumMember(Value = "BOOLEAN")]
        Boolean,
        [EnumMember(Value = "DATE")]
        Date
    }
}

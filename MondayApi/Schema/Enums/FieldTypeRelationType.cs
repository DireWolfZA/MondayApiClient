using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum FieldTypeRelationType {
        [EnumMember(Value = "PRIMITIVE")]
        Primitive,
        [EnumMember(Value = "INTERFACE")]
        Interface,
        [EnumMember(Value = "CUSTOM")]
        Custom
    }
}

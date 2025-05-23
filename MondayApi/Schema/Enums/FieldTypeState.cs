using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum FieldTypeState {
        [EnumMember(Value = "ACTIVE")]
        Active,
        [EnumMember(Value = "DELETED")]
        Deleted
    }
}

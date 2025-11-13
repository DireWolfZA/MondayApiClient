using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum ObjectState {
        [EnumMember(Value = "ACTIVE")]
        Active,
        [EnumMember(Value = "ARCHIVED")]
        Archived,
        [EnumMember(Value = "DELETED")]
        Deleted
    }
}

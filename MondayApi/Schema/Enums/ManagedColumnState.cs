using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum ManagedColumnState {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "deleted")]
        Deleted,
        [EnumMember(Value = "inactive")]
        Inactive
    }
}

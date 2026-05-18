using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum SequenceStatus {
        [EnumMember(Value = "ACTIVE")]
        Active,
        [EnumMember(Value = "INACTIVE")]
        Inactive,
        [EnumMember(Value = "MISSING_CONFIG")]
        MissingConfig,
        [EnumMember(Value = "DELETED")]
        Deleted
    }
}

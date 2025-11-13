using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum SprintSnapshotKind {
        [EnumMember(Value = "START")]
        Start,
        [EnumMember(Value = "COMPLETE")]
        Complete
    }
}

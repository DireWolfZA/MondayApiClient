using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum VersionKind {
        [EnumMember(Value = "deprecated")]
        Deprecated,
        [EnumMember(Value = "dev")]
        Dev,
        [EnumMember(Value = "previous_maintenance")]
        PreviousMaintenance,
        [EnumMember(Value = "maintenance")]
        Maintenance,
        [EnumMember(Value = "current")]
        Current,
        [EnumMember(Value = "old_previous_maintenance")]
        OldPreviousMaintenance,
        [EnumMember(Value = "release_candidate")]
        ReleaseCandidate
    }
}

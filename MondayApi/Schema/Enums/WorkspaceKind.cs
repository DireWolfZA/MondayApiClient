using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum WorkspaceKind {
        [EnumMember(Value = "open")]
        Open,
        [EnumMember(Value = "closed")]
        Closed
    }
}

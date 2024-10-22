using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum WorkspaceKind {
        [EnumMember(Value = "closed")]
        Closed,
        [EnumMember(Value = "open")]
        Open
    }
}

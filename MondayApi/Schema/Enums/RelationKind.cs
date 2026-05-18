using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum RelationKind {
        [EnumMember(Value = "ALIAS")]
        Alias,
        [EnumMember(Value = "DEPENDENCY")]
        Dependency
    }
}

using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum BoardBasicRoleName {
        [EnumMember(Value = "assigned_contributor")]
        AssignedContributor,
        [EnumMember(Value = "contributor")]
        Contributor,
        [EnumMember(Value = "editor")]
        Editor,
        [EnumMember(Value = "viewer")]
        Viewer
    }
}

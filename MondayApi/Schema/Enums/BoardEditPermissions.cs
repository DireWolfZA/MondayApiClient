using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum BoardEditPermissions {
        [EnumMember(Value = "assignee")]
        Assignee,
        [EnumMember(Value = "collaborators")]
        Collaborators,
        [EnumMember(Value = "everyone")]
        Everyone,
        [EnumMember(Value = "owners")]
        Owners
    }
}

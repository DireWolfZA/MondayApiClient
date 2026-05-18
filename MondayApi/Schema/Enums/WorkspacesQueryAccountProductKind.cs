using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum WorkspacesQueryAccountProductKind {
        [EnumMember(Value = "core")]
        Core,
        [EnumMember(Value = "crm")]
        CRM,
        [EnumMember(Value = "forms")]
        Forms,
        [EnumMember(Value = "marketing")]
        Marketing,
        [EnumMember(Value = "project_management")]
        ProjectManagement,
        [EnumMember(Value = "service")]
        Service,
        [EnumMember(Value = "software")]
        Software,
        [EnumMember(Value = "whiteboard")]
        Whiteboard
    }
}

using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum AccountProductKind {
        [EnumMember(Value = "core")] Core,
        [EnumMember(Value = "marketing")] Marketing,
        [EnumMember(Value = "crm")] Crm,
        [EnumMember(Value = "software")] Software,
        projectManagement,
        [EnumMember(Value = "project_management")] ProjectManagement,
        [EnumMember(Value = "forms")] Forms,
        [EnumMember(Value = "whiteboard")] Whiteboard
    }
}

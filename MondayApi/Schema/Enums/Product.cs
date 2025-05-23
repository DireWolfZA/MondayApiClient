using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum Product {
        [EnumMember(Value = "work_management")]
        WorkManagement,
        [EnumMember(Value = "crm")]
        Crm,
        [EnumMember(Value = "dev")]
        Dev,
        [EnumMember(Value = "service")]
        Service,
        [EnumMember(Value = "whiteboard")]
        Whiteboard,
        [EnumMember(Value = "knowledge")]
        Knowledge,
        [EnumMember(Value = "forms")]
        Forms,
        [EnumMember(Value = "workflows")]
        Workflows
    }
}

using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum CustomizableBoardSettings {
        [EnumMember(Value = "IM_MENTIONED")]
        ImMentioned,
        [EnumMember(Value = "IM_ASSIGNED")]
        ImAssigned,
        [EnumMember(Value = "AUTOMATION_NOTIFY")]
        AutomationNotify
    }
}

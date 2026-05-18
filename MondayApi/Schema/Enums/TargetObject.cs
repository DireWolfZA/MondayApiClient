using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum TargetObject {
        [EnumMember(Value = "BOARD")]
        Board,
        [EnumMember(Value = "DASHBOARD")]
        Dashboard
    }
}

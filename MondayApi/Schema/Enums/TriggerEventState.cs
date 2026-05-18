using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum TriggerEventState {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "failure")]
        Failure,
        [EnumMember(Value = "exhausted")]
        Exhausted
    }
}

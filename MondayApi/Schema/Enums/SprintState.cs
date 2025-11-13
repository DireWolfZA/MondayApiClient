using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum SprintState {
        [EnumMember(Value = "PLANNED")]
        Planned,
        [EnumMember(Value = "ACTIVE")]
        Active,
        [EnumMember(Value = "COMPLETED")]
        Completed
    }
}

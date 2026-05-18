using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum MeetingAccessFilter {
        [EnumMember(Value = "OWN")]
        Own,
        [EnumMember(Value = "SHARED_WITH_ME")]
        SharedWithMe,
        [EnumMember(Value = "SHARED_WITH_ACCOUNT")]
        SharedWithAccount,
        [EnumMember(Value = "ALL")]
        All
    }
}

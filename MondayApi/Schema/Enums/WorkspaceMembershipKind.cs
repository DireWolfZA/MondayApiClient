using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum WorkspaceMembershipKind {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "member")]
        Member
    }
}

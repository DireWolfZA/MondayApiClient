using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum UserRole {
        [EnumMember(Value = "PORTAL_USER")]
        PortalUser,
        [EnumMember(Value = "GUEST")]
        Guest,
        [EnumMember(Value = "VIEW_ONLY")]
        ViewOnly,
        [EnumMember(Value = "MEMBER")]
        Member,
        [EnumMember(Value = "ADMIN")]
        Admin
    }
}

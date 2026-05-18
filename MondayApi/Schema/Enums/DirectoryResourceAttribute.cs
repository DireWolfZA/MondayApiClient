using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum DirectoryResourceAttribute {
        [EnumMember(Value = "JOB_ROLE")]
        JobRole,
        [EnumMember(Value = "SKILLS")]
        Skills,
        [EnumMember(Value = "LOCATION")]
        Location
    }
}

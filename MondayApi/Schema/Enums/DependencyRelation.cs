using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum DependencyRelation {
        [EnumMember(Value = "FS")]
        FS,
        [EnumMember(Value = "SS")]
        SS,
        [EnumMember(Value = "FF")]
        FF,
        [EnumMember(Value = "SF")]
        SF
    }
}

using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum BoardHierarchy {
        [EnumMember(Value = "classic")]
        Classic,
        [EnumMember(Value = "multi_level")]
        MultiLevel
    }
}

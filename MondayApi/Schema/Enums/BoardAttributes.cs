using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum BoardAttributes {
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "description")]
        Description,
        [EnumMember(Value = "communication")]
        Communication
    }
}

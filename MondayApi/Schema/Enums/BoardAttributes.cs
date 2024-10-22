using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum BoardAttributes {
        [EnumMember(Value = "communication")]
        Communication,
        [EnumMember(Value = "description")]
        Description,
        [EnumMember(Value = "name")]
        Name
    }
}

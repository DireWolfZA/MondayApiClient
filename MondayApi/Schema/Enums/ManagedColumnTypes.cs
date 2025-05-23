using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum ManagedColumnTypes {
        [EnumMember(Value = "status")]
        Status,
        [EnumMember(Value = "dropdown")]
        Dropdown
    }
}

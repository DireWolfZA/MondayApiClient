using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum State {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "archived")]
        Archived,
        [EnumMember(Value = "deleted")]
        Deleted
    }
}

using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum DashboardKind {
        [EnumMember(Value = "PUBLIC")]
        Public,
        [EnumMember(Value = "PRIVATE")]
        Private
    }
}

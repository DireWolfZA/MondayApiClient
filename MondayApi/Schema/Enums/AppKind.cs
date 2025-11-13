using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum AppKind {
        [EnumMember(Value = "PRIVATE")]
        Private,
        [EnumMember(Value = "PUBLIC")]
        Public
    }
}

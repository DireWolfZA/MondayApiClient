using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum PrivacyKind {
        [EnumMember(Value = "PRIVATE")]
        Private,
        [EnumMember(Value = "PUBLIC")]
        Public
    }
}

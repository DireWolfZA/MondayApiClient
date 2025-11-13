using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum DocKind {
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "share")]
        Share
    }
}

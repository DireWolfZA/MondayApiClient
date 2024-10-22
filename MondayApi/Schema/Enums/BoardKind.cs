using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum BoardKind {
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "share")]
        Share
    }
}

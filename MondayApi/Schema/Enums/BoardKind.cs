using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum BoardKind {
        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "share")]
        Share
    }
}

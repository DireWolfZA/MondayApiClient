using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum DocsOrderBy {
        [EnumMember(Value = "created_at")]
        CreatedAt,
        [EnumMember(Value = "used_at")]
        UsedAt
    }
}

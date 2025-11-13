using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum OrderBy {
        [EnumMember(Value = "CREATED_AT")]
        CreatedAt,
        [EnumMember(Value = "USED_AT")]
        UsedAt
    }
}

using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum WorkspacesOrderBy {
        [EnumMember(Value = "created_at")] CreatedAt
    }
}

using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum SortDirection {
        [EnumMember(Value = "ASC")]
        Ascending,
        [EnumMember(Value = "DESC")]
        Descending
    }
}

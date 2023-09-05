using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum ItemsOrderByDirection {
        [EnumMember(Value = "asc")]
        Ascending,
        [EnumMember(Value = "desc")]
        Descending
    }
}

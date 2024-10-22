using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum ColumnProperty {
        [EnumMember(Value = "description")]
        Description,
        [EnumMember(Value = "title")]
        Title
    }
}

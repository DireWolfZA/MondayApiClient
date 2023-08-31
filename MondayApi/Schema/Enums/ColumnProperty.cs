using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum ColumnProperty {
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "description")]
        Description
    }
}

using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum ItemsQueryOperator {
        [EnumMember(Value = "or")]
        Or,
        [EnumMember(Value = "and")]
        And
    }
}

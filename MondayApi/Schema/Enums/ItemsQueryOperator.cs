using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum ItemsQueryOperator {
        [EnumMember(Value = "and")]
        And,
        [EnumMember(Value = "or")]
        Or
    }
}

using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum UpdateUserAttributesErrorCode {
        [EnumMember(Value = "INVALID_FIELD")]
        InvalidField
    }
}

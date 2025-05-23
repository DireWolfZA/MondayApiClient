using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum DeactivateUsersErrorCode {
        [EnumMember(Value = "EXCEEDS_BATCH_LIMIT")]
        ExceedsBatchLimit,
        [EnumMember(Value = "INVALID_INPUT")]
        InvalidInput,
        [EnumMember(Value = "USER_NOT_FOUND")]
        UserNotFound,
        [EnumMember(Value = "CANNOT_UPDATE_SELF")]
        CannotUpdateSelf,
        [EnumMember(Value = "FAILED")]
        Failed
    }
}

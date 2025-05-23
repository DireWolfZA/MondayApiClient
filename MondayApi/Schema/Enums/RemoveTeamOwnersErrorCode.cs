using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum RemoveTeamOwnersErrorCode {
        [EnumMember(Value = "VIEWERS_OR_GUESTS")]
        ViewersOrGuests,
        [EnumMember(Value = "USER_NOT_MEMBER_OF_TEAM")]
        UserNotMemberOfTeam,
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

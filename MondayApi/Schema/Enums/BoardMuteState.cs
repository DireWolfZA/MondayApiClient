using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum BoardMuteState {
        [EnumMember(Value = "NOT_MUTED")]
        NotMuted,
        [EnumMember(Value = "MUTE_ALL")]
        MuteAll,
        [EnumMember(Value = "MENTIONS_AND_ASSIGNS_ONLY")]
        MentionsAndAssignsOnly,
        [EnumMember(Value = "CUSTOM_SETTINGS")]
        CustomSettings,
        [EnumMember(Value = "CURRENT_USER_MUTE_ALL")]
        CurrentUserMuteAll
    }
}

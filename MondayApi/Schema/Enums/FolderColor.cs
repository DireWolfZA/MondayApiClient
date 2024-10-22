using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum FolderColor {
        [EnumMember(Value = "AQUAMARINE")]
        Aquamarine,
        [EnumMember(Value = "BRIGHT_BLUE")]
        BrightBlue,
        [EnumMember(Value = "BRIGHT_GREEN")]
        BrightGreen,
        [EnumMember(Value = "CHILI_BLUE")]
        ChiliBlue,
        [EnumMember(Value = "DARK_ORANGE")]
        DarkOrange,
        [EnumMember(Value = "DARK_PURPLE")]
        DarkPurple,
        [EnumMember(Value = "DARK_RED")]
        DarkRed,
        [EnumMember(Value = "DONE_GREEN")]
        DoneGreen,
        [EnumMember(Value = "INDIGO")]
        Indigo,
        [EnumMember(Value = "LIPSTICK")]
        Lipstick,
        [EnumMember(Value = "NULL")]
        Null,
        [EnumMember(Value = "PURPLE")]
        Purple,
        [EnumMember(Value = "SOFIA_PINK")]
        SofiaPink,
        [EnumMember(Value = "STUCK_RED")]
        StuckRed,
        [EnumMember(Value = "SUNSET")]
        Sunset,
        [EnumMember(Value = "WORKING_ORANGE")]
        WorkingOrange
    }
}

using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum FolderColor {
        [EnumMember(Value = "DONE_GREEN")]
        DoneGreen,
        [EnumMember(Value = "BRIGHT_GREEN")]
        BrightGreen,
        [EnumMember(Value = "WORKING_ORANGE")]
        WorkingOrange,
        [EnumMember(Value = "DARK_ORANGE")]
        DarkOrange,
        [EnumMember(Value = "SUNSET")]
        Sunset,
        [EnumMember(Value = "STUCK_RED")]
        StuckRed,
        [EnumMember(Value = "DARK_RED")]
        DarkRed,
        [EnumMember(Value = "SOFIA_PINK")]
        SofiaPink,
        [EnumMember(Value = "LIPSTICK")]
        Lipstick,
        [EnumMember(Value = "PURPLE")]
        Purple,
        [EnumMember(Value = "DARK_PURPLE")]
        DarkPurple,
        [EnumMember(Value = "INDIGO")]
        Indigo,
        [EnumMember(Value = "BRIGHT_BLUE")]
        BrightBlue,
        [EnumMember(Value = "AQUAMARINE")]
        Aquamarine,
        [EnumMember(Value = "CHILI_BLUE")]
        ChiliBlue,
        [EnumMember(Value = "NULL")]
        Null
    }
}

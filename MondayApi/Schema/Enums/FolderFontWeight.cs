using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum FolderFontWeight {
        [EnumMember(Value = "FONT_WEIGHT_VERY_LIGHT")]
        FontWeightVeryLight,
        [EnumMember(Value = "FONT_WEIGHT_LIGHT")]
        FontWeightLight,
        [EnumMember(Value = "FONT_WEIGHT_NORMAL")]
        FontWeightNormal,
        [EnumMember(Value = "FONT_WEIGHT_BOLD")]
        FontWeightBold,
        [EnumMember(Value = "NULL")]
        Null
    }
}

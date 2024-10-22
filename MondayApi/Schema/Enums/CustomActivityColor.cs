using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum CustomActivityColor {
        [EnumMember(Value = "VIVID_CERULEAN")]
        VividCerulean,
        [EnumMember(Value = "GO_GREEN")]
        GoGreen,
        [EnumMember(Value = "PHILIPPINE_GREEN")]
        PhilippineGreen,
        [EnumMember(Value = "YANKEES_BLUE")]
        YankeesBlue,
        [EnumMember(Value = "CELTIC_BLUE")]
        CelticBlue,
        [EnumMember(Value = "MEDIUM_TURQUOISE")]
        MediumTurquoise,
        [EnumMember(Value = "CORNFLOWER_BLUE")]
        CornflowerBlue,
        [EnumMember(Value = "MAYA_BLUE")]
        MayaBlue,
        [EnumMember(Value = "SLATE_BLUE")]
        SlateBlue,
        [EnumMember(Value = "GRAY")]
        Gray,
        [EnumMember(Value = "YELLOW_GREEN")]
        YellowGreen,
        [EnumMember(Value = "DINGY_DUNGEON")]
        DingyDungeon,
        [EnumMember(Value = "PARADISE_PINK")]
        ParadisePink,
        [EnumMember(Value = "BRINK_PINK")]
        BrinkPink,
        [EnumMember(Value = "YELLOW_ORANGE")]
        YellowOrange,
        [EnumMember(Value = "LIGHT_DEEP_PINK")]
        LightDeepPink,
        [EnumMember(Value = "LIGHT_HOT_PINK")]
        LightHotPink,
        [EnumMember(Value = "PHILIPPINE_YELLOW")]
        PhilippineYellow
    }
}

using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum CustomActivityIcon {
        [EnumMember(Value = "ASCENDING")]
        Ascending,
        [EnumMember(Value = "CAMERA")]
        Camera,
        [EnumMember(Value = "CONFERENCE")]
        Conference,
        [EnumMember(Value = "FLAG")]
        Flag,
        [EnumMember(Value = "GIFT")]
        Gift,
        [EnumMember(Value = "HEADPHONES")]
        Headphones,
        [EnumMember(Value = "HOMEKEYS")]
        Homekeys,
        [EnumMember(Value = "LOCATION")]
        Location,
        [EnumMember(Value = "PAPERPLANE")]
        Paperplane,
        [EnumMember(Value = "PLANE")]
        Plane,
        [EnumMember(Value = "NOTEBOOK")]
        Notebook,
        [EnumMember(Value = "PLIERS")]
        Pliers,
        [EnumMember(Value = "TRIPOD")]
        Tripod,
        [EnumMember(Value = "TWOFLAGS")]
        Twoflags,
        [EnumMember(Value = "UTENCILS")]
        Utencils
    }
}

using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum AppFeatureReleaseKind {
        [EnumMember(Value = "SERVER_SIDE_CODE")]
        ServerSideCode,
        [EnumMember(Value = "CLIENT_SIDE_CODE")]
        ClientSideCode,
        [EnumMember(Value = "EXTERNAL_HOSTING")]
        ExternalHosting
    }
}

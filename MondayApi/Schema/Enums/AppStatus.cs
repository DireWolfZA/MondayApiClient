using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum AppStatus {
        [EnumMember(Value = "DRAFT")]
        Draft,
        [EnumMember(Value = "LIVE")]
        Live
    }
}

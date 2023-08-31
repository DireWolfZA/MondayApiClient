using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum VersionKind {
        [EnumMember(Value = "deprecated")] Deprecated,
        [EnumMember(Value = "stable")] Stable,
        [EnumMember(Value = "preview")] Preview,
        [EnumMember(Value = "dev")] Dev
    }
}

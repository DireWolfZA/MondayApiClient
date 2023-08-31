using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum WorkspaceSubscriberKind {
        [EnumMember(Value = "subscriber")]
        Subscriber,
        [EnumMember(Value = "owner")]
        Owner
    }
}

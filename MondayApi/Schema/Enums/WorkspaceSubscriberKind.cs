using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum WorkspaceSubscriberKind {
        [EnumMember(Value = "owner")]
        Owner,
        [EnumMember(Value = "subscriber")]
        Subscriber
    }
}

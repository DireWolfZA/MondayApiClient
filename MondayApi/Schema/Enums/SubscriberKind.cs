using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum SubscriberKind {
        [EnumMember(Value = "OWNER")]
        Owner,
        [EnumMember(Value = "SUBSCRIBER")]
        Subscriber
    }
}

using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum BoardSubscriberKind {
        [EnumMember(Value = "owner")]
        Owner,
        [EnumMember(Value = "subscriber")]
        Subscriber
    }
}

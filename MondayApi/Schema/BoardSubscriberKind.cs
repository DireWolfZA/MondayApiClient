using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum BoardSubscriberKind {
        [EnumMember(Value = "subscriber")] Subscriber,
        [EnumMember(Value = "owner")] Owner
    }
}

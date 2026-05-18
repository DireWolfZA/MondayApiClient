using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum RelationDirection {
        [EnumMember(Value = "OUTGOING")]
        Outgoing,
        [EnumMember(Value = "INCOMING")]
        Incoming
    }
}

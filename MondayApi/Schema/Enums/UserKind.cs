using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum UserKind {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "guests")]
        Guests,
        [EnumMember(Value = "non_guests")]
        NonGuests,
        [EnumMember(Value = "non_pending")]
        NonPending
    }
}

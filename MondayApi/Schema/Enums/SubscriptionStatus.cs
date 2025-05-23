using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum SubscriptionStatus {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive
    }
}

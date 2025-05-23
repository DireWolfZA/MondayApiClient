using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum SubscriptionDiscountType {
        [EnumMember(Value = "recurring")]
        Recurring,
        [EnumMember(Value = "one_time")]
        OneTime
    }
}

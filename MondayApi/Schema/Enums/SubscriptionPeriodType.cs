using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum SubscriptionPeriodType {
        [EnumMember(Value = "monthly")]
        Monthly,
        [EnumMember(Value = "yearly")]
        Yearly
    }
}

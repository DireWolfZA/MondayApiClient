using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum SubscriptionDiscountModelType {
        [EnumMember(Value = "percent")]
        Percent,
        [EnumMember(Value = "nominal")]
        Nominal
    }
}

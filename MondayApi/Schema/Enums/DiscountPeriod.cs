using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum DiscountPeriod {
        [EnumMember(Value = "MONTHLY")]
        Monthly,
        [EnumMember(Value = "YEARLY")]
        Yearly
    }
}

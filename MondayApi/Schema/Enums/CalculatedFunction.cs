using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum CalculatedFunction {
        [EnumMember(Value = "MIN")]
        Min,
        [EnumMember(Value = "MAX")]
        Max,
        [EnumMember(Value = "SUM")]
        Sum,
        [EnumMember(Value = "MIN_MAX")]
        MinMax,
        [EnumMember(Value = "NONE")]
        None,
        [EnumMember(Value = "COUNT_KEYS")]
        CountKeys
    }
}

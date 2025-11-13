using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum AggregateSelectFunctionName {
        [EnumMember(Value = "NONE")]
        None,
        [EnumMember(Value = "COUNT_ITEMS")]
        CountItems,
        [EnumMember(Value = "COUNT_SUBITEMS")]
        CountSubitems,
        [EnumMember(Value = "COUNT")]
        Count,
        [EnumMember(Value = "COUNT_DISTINCT")]
        CountDistinct,
        [EnumMember(Value = "COUNT_KEYS")]
        CountKeys,
        [EnumMember(Value = "SUM")]
        Sum,
        [EnumMember(Value = "AVERAGE")]
        Average,
        [EnumMember(Value = "MEDIAN")]
        Median,
        [EnumMember(Value = "MIN")]
        Min,
        [EnumMember(Value = "MAX")]
        Max,
        [EnumMember(Value = "MIN_MAX")]
        MinMax,
        [EnumMember(Value = "BETWEEN")]
        Between,
        [EnumMember(Value = "DURATION_RUNNING")]
        DurationRunning,
        [EnumMember(Value = "UPPER")]
        Upper,
        [EnumMember(Value = "LOWER")]
        Lower,
        [EnumMember(Value = "TRIM")]
        Trim,
        [EnumMember(Value = "LENGTH")]
        Length,
        [EnumMember(Value = "FIRST")]
        First,
        [EnumMember(Value = "LEFT")]
        Left,
        [EnumMember(Value = "FLATTEN")]
        Flatten,
        [EnumMember(Value = "CASE")]
        Case,
        [EnumMember(Value = "EQUALS")]
        Equals,
        [EnumMember(Value = "DATE_TRUNC_DAY")]
        DateTruncDay,
        [EnumMember(Value = "DATE_TRUNC_WEEK")]
        DateTruncWeek,
        [EnumMember(Value = "DATE_TRUNC_MONTH")]
        DateTruncMonth,
        [EnumMember(Value = "DATE_TRUNC_QUARTER")]
        DateTruncQuarter,
        [EnumMember(Value = "DATE_TRUNC_YEAR")]
        DateTruncYear,
        [EnumMember(Value = "DATE")]
        Date,
        [EnumMember(Value = "START_DATE")]
        StartDate,
        [EnumMember(Value = "END_DATE")]
        EndDate,
        [EnumMember(Value = "HOUR")]
        Hour,
        [EnumMember(Value = "PERSON")]
        Person,
        [EnumMember(Value = "ID")]
        Id,
        [EnumMember(Value = "LABEL")]
        Label,
        [EnumMember(Value = "COLOR")]
        Color,
        [EnumMember(Value = "ORDER")]
        Order,
        [EnumMember(Value = "RAW")]
        Raw,
        [EnumMember(Value = "IS_DONE")]
        IsDone,
        [EnumMember(Value = "PHONE_COUNTRY_SHORT_NAME")]
        PhoneCountryShortName
    }
}

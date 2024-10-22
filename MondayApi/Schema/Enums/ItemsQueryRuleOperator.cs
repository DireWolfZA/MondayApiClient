using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum ItemsQueryRuleOperator {
        [EnumMember(Value = "any_of")]
        AnyOf,
        [EnumMember(Value = "between")]
        Between,
        [EnumMember(Value = "contains_terms")]
        ContainsTerms,
        [EnumMember(Value = "contains_text")]
        ContainsText,
        [EnumMember(Value = "ends_with")]
        EndsWith,
        [EnumMember(Value = "greater_than")]
        GreaterThan,
        [EnumMember(Value = "greater_than_or_equals")]
        GreaterThanOrEquals,
        [EnumMember(Value = "is_empty")]
        IsEmpty,
        [EnumMember(Value = "is_not_empty")]
        IsNotEmpty,
        [EnumMember(Value = "lower_than")]
        LowerThan,
        [EnumMember(Value = "lower_than_or_equal")]
        LowerThanOrEqualss,
        [EnumMember(Value = "not_any_of")]
        NotAnyOf,
        [EnumMember(Value = "not_contains_text")]
        NotContainsText,
        [EnumMember(Value = "starts_with")]
        StartsWith,
        [EnumMember(Value = "within_the_last")]
        WithinTheLast,
        [EnumMember(Value = "within_the_next")]
        WithinTheNext
    }
}

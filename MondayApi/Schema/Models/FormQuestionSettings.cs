namespace MondayApi.Schema {
    public class FormQuestionSettings {
        public PrefillSettings? Prefill { get; set; }
        public bool? PrefixAutofilled { get; set; }
        public PhonePrefixPredefined? PrefixPredefined { get; set; }
        public bool? CheckedByDefault { get; set; }
        public bool? DefaultCurrentDate { get; set; }
        public bool? IncludeTime { get; set; }
        public FormQuestionSelectDisplay? Display { get; set; }
        public FormQuestionSelectOrderByOptions? OptionsOrder { get; set; }
        public bool? LocationAutofilled { get; set; }
        public int? Limit { get; set; }
        public bool? SkipValidation { get; set; }
    }
}

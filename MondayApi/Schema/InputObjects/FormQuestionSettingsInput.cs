using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class FormQuestionSettingsInput : IGraphQlInputObject {
        private InputPropertyInfo _prefill;
        private InputPropertyInfo _prefixAutofilled;
        private InputPropertyInfo _prefixPredefined;
        private InputPropertyInfo _checkedByDefault;
        private InputPropertyInfo _defaultCurrentDate;
        private InputPropertyInfo _includeTime;
        private InputPropertyInfo _display;
        private InputPropertyInfo _optionsOrder;
        private InputPropertyInfo _labelLimitCount;
        private InputPropertyInfo _locationAutofilled;
        private InputPropertyInfo _skipValidation;

        [JsonConverter(typeof(QueryBuilderParameterConverter<PrefillSettingsInput?>))]
        public QueryBuilderParameter<PrefillSettingsInput?>? Prefill {
            get => (QueryBuilderParameter<PrefillSettingsInput?>?)_prefill.Value;
            set => _prefill = new InputPropertyInfo { Name = "prefill", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? PrefixAutofilled {
            get => (QueryBuilderParameter<bool?>?)_prefixAutofilled.Value;
            set => _prefixAutofilled = new InputPropertyInfo { Name = "prefixAutofilled", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<PhonePrefixPredefinedInput?>))]
        public QueryBuilderParameter<PhonePrefixPredefinedInput?>? PrefixPredefined {
            get => (QueryBuilderParameter<PhonePrefixPredefinedInput?>?)_prefixPredefined.Value;
            set => _prefixPredefined = new InputPropertyInfo { Name = "prefixPredefined", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? CheckedByDefault {
            get => (QueryBuilderParameter<bool?>?)_checkedByDefault.Value;
            set => _checkedByDefault = new InputPropertyInfo { Name = "checkedByDefault", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? DefaultCurrentDate {
            get => (QueryBuilderParameter<bool?>?)_defaultCurrentDate.Value;
            set => _defaultCurrentDate = new InputPropertyInfo { Name = "defaultCurrentDate", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? IncludeTime {
            get => (QueryBuilderParameter<bool?>?)_includeTime.Value;
            set => _includeTime = new InputPropertyInfo { Name = "includeTime", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormQuestionSelectDisplay?>))]
        public QueryBuilderParameter<FormQuestionSelectDisplay?>? Display {
            get => (QueryBuilderParameter<FormQuestionSelectDisplay?>?)_display.Value;
            set => _display = new InputPropertyInfo { Name = "display", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormQuestionSelectOrderByOptions?>))]
        public QueryBuilderParameter<FormQuestionSelectOrderByOptions?>? OptionsOrder {
            get => (QueryBuilderParameter<FormQuestionSelectOrderByOptions?>?)_optionsOrder.Value;
            set => _optionsOrder = new InputPropertyInfo { Name = "optionsOrder", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        public QueryBuilderParameter<int?>? LabelLimitCount {
            get => (QueryBuilderParameter<int?>?)_labelLimitCount.Value;
            set => _labelLimitCount = new InputPropertyInfo { Name = "labelLimitCount", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? LocationAutofilled {
            get => (QueryBuilderParameter<bool?>?)_locationAutofilled.Value;
            set => _locationAutofilled = new InputPropertyInfo { Name = "locationAutofilled", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? SkipValidation {
            get => (QueryBuilderParameter<bool?>?)_skipValidation.Value;
            set => _skipValidation = new InputPropertyInfo { Name = "skipValidation", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_prefill.Name != null) yield return _prefill;
            if (_prefixAutofilled.Name != null) yield return _prefixAutofilled;
            if (_prefixPredefined.Name != null) yield return _prefixPredefined;
            if (_checkedByDefault.Name != null) yield return _checkedByDefault;
            if (_defaultCurrentDate.Name != null) yield return _defaultCurrentDate;
            if (_includeTime.Name != null) yield return _includeTime;
            if (_display.Name != null) yield return _display;
            if (_optionsOrder.Name != null) yield return _optionsOrder;
            if (_labelLimitCount.Name != null) yield return _labelLimitCount;
            if (_locationAutofilled.Name != null) yield return _locationAutofilled;
            if (_skipValidation.Name != null) yield return _skipValidation;
        }
    }
}

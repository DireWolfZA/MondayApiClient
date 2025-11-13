using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CreateDropdownColumnSettingsInput : IGraphQlInputObject {
        private InputPropertyInfo _labels;
        private InputPropertyInfo _limitSelect;
        private InputPropertyInfo _labelLimitCount;

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<CreateDropdownLabelInput>?>))]
        public QueryBuilderParameter<ICollection<CreateDropdownLabelInput>?>? Labels {
            get => (QueryBuilderParameter<ICollection<CreateDropdownLabelInput>?>?)_labels.Value;
            set => _labels = new InputPropertyInfo { Name = "labels", Value = value };
        }

        [JsonProperty("limit_select")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? LimitSelect {
            get => (QueryBuilderParameter<bool?>?)_limitSelect.Value;
            set => _limitSelect = new InputPropertyInfo { Name = "limit_select", Value = value };
        }

        [JsonProperty("label_limit_count")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        public QueryBuilderParameter<int?>? LabelLimitCount {
            get => (QueryBuilderParameter<int?>?)_labelLimitCount.Value;
            set => _labelLimitCount = new InputPropertyInfo { Name = "label_limit_count", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_labels.Name != null) yield return _labels;
            if (_limitSelect.Name != null) yield return _limitSelect;
            if (_labelLimitCount.Name != null) yield return _labelLimitCount;
        }
    }
}

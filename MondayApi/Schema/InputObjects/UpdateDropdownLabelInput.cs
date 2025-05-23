using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UpdateDropdownLabelInput : IGraphQlInputObject {
        private InputPropertyInfo _label;
        private InputPropertyInfo _id;
        private InputPropertyInfo _isDeactivated;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Label {
            get => (QueryBuilderParameter<string?>?)_label.Value;
            set => _label = new InputPropertyInfo { Name = "label", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        public QueryBuilderParameter<int?>? ID {
            get => (QueryBuilderParameter<int?>?)_id.Value;
            set => _id = new InputPropertyInfo { Name = "id", Value = value };
        }

        [JsonProperty("is_deactivated")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? IsDeactivated {
            get => (QueryBuilderParameter<bool?>?)_isDeactivated.Value;
            set => _isDeactivated = new InputPropertyInfo { Name = "is_deactivated", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_label.Name != null) yield return _label;
            if (_id.Name != null) yield return _id;
            if (_isDeactivated.Name != null) yield return _isDeactivated;
        }
    }
}

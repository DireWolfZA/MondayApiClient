using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CreateDropdownLabelInput : IGraphQlInputObject {
        private InputPropertyInfo _label;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Label {
            get => (QueryBuilderParameter<string?>?)_label.Value;
            set => _label = new InputPropertyInfo { Name = "label", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_label.Name != null) yield return _label;
        }
    }
}

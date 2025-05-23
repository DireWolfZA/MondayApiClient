using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CreateDropdownColumnSettingsInput : IGraphQlInputObject {
        private InputPropertyInfo _labels;

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<CreateDropdownLabelInput>?>))]
        public QueryBuilderParameter<ICollection<CreateDropdownLabelInput>?>? Labels {
            get => (QueryBuilderParameter<ICollection<CreateDropdownLabelInput>?>?)_labels.Value;
            set => _labels = new InputPropertyInfo { Name = "labels", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_labels.Name != null) yield return _labels;
        }
    }
}

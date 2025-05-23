using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UpdateDropdownColumnSettingsInput : IGraphQlInputObject {
        private InputPropertyInfo _labels;

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<UpdateDropdownLabelInput>?>))]
        public QueryBuilderParameter<ICollection<UpdateDropdownLabelInput>?>? Labels {
            get => (QueryBuilderParameter<ICollection<UpdateDropdownLabelInput>?>?)_labels.Value;
            set => _labels = new InputPropertyInfo { Name = "labels", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_labels.Name != null) yield return _labels;
        }
    }
}

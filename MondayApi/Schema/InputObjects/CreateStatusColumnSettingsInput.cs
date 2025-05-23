using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CreateStatusColumnSettingsInput : IGraphQlInputObject {
        private InputPropertyInfo _labels;

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<CreateStatusLabelInput>?>))]
        public QueryBuilderParameter<ICollection<CreateStatusLabelInput>?>? Labels {
            get => (QueryBuilderParameter<ICollection<CreateStatusLabelInput>?>?)_labels.Value;
            set => _labels = new InputPropertyInfo { Name = "labels", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_labels.Name != null) yield return _labels;
        }
    }
}

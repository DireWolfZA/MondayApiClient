using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UpdateStatusColumnSettingsInput : IGraphQlInputObject {
        private InputPropertyInfo _labels;

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<UpdateStatusLabelInput>?>))]
        public QueryBuilderParameter<ICollection<UpdateStatusLabelInput>?>? Labels {
            get => (QueryBuilderParameter<ICollection<UpdateStatusLabelInput>?>?)_labels.Value;
            set => _labels = new InputPropertyInfo { Name = "labels", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_labels.Name != null) yield return _labels;
        }
    }
}

using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CreateStatusLabelInput : IGraphQlInputObject {
        private InputPropertyInfo _label;
        private InputPropertyInfo _color;
        private InputPropertyInfo _index;
        private InputPropertyInfo _description;
        private InputPropertyInfo _isDone;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Label {
            get => (QueryBuilderParameter<string?>?)_label.Value;
            set => _label = new InputPropertyInfo { Name = "label", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<StatusColumnColors?>))]
        public QueryBuilderParameter<StatusColumnColors?>? Color {
            get => (QueryBuilderParameter<StatusColumnColors?>?)_color.Value;
            set => _color = new InputPropertyInfo { Name = "color", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        public QueryBuilderParameter<int?>? Index {
            get => (QueryBuilderParameter<int?>?)_index.Value;
            set => _index = new InputPropertyInfo { Name = "index", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Description {
            get => (QueryBuilderParameter<string?>?)_description.Value;
            set => _description = new InputPropertyInfo { Name = "description", Value = value };
        }

        [JsonProperty("is_done")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? IsDone {
            get => (QueryBuilderParameter<bool?>?)_isDone.Value;
            set => _isDone = new InputPropertyInfo { Name = "is_done", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_label.Name != null) yield return _label;
            if (_color.Name != null) yield return _color;
            if (_index.Name != null) yield return _index;
            if (_description.Name != null) yield return _description;
            if (_isDone.Name != null) yield return _isDone;
        }
    }
}

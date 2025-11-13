using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class FormLayoutInput : IGraphQlInputObject {
        private InputPropertyInfo _format;
        private InputPropertyInfo _alignment;
        private InputPropertyInfo _direction;

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormFormat?>))]
        public QueryBuilderParameter<FormFormat?>? Format {
            get => (QueryBuilderParameter<FormFormat?>?)_format.Value;
            set => _format = new InputPropertyInfo { Name = "format", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormAlignment?>))]
        public QueryBuilderParameter<FormAlignment?>? Alignment {
            get => (QueryBuilderParameter<FormAlignment?>?)_alignment.Value;
            set => _alignment = new InputPropertyInfo { Name = "alignment", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormDirection?>))]
        public QueryBuilderParameter<FormDirection?>? Direction {
            get => (QueryBuilderParameter<FormDirection?>?)_direction.Value;
            set => _direction = new InputPropertyInfo { Name = "direction", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_format.Name != null) yield return _format;
            if (_alignment.Name != null) yield return _alignment;
            if (_direction.Name != null) yield return _direction;
        }
    }
}

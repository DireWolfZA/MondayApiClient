using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class FormLogoInput : IGraphQlInputObject {
        private InputPropertyInfo _position;
        private InputPropertyInfo _size;

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormLogoPosition?>))]
        public QueryBuilderParameter<FormLogoPosition?>? Position {
            get => (QueryBuilderParameter<FormLogoPosition?>?)_position.Value;
            set => _position = new InputPropertyInfo { Name = "position", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormLogoSize?>))]
        public QueryBuilderParameter<FormLogoSize?>? Size {
            get => (QueryBuilderParameter<FormLogoSize?>?)_size.Value;
            set => _size = new InputPropertyInfo { Name = "size", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_position.Name != null) yield return _position;
            if (_size.Name != null) yield return _size;
        }
    }
}

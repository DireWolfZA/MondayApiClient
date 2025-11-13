using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class FormTextInput : IGraphQlInputObject {
        private InputPropertyInfo _font;
        private InputPropertyInfo _color;
        private InputPropertyInfo _size;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Font {
            get => (QueryBuilderParameter<string?>?)_font.Value;
            set => _font = new InputPropertyInfo { Name = "font", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Color {
            get => (QueryBuilderParameter<string?>?)_color.Value;
            set => _color = new InputPropertyInfo { Name = "color", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormFontSize?>))]
        public QueryBuilderParameter<FormFontSize?>? Size {
            get => (QueryBuilderParameter<FormFontSize?>?)_size.Value;
            set => _size = new InputPropertyInfo { Name = "size", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_font.Name != null) yield return _font;
            if (_color.Name != null) yield return _color;
            if (_size.Name != null) yield return _size;
        }
    }
}

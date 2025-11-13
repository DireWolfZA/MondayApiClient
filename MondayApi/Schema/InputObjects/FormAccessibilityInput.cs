using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class FormAccessibilityInput : IGraphQlInputObject {
        private InputPropertyInfo _language;
        private InputPropertyInfo _logoAltText;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Language {
            get => (QueryBuilderParameter<string?>?)_language.Value;
            set => _language = new InputPropertyInfo { Name = "language", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? LogoAltText {
            get => (QueryBuilderParameter<string?>?)_logoAltText.Value;
            set => _logoAltText = new InputPropertyInfo { Name = "logoAltText", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_language.Name != null) yield return _language;
            if (_logoAltText.Name != null) yield return _logoAltText;
        }
    }
}

using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class FormSubmitButtonInput : IGraphQlInputObject {
        private InputPropertyInfo _text;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Text {
            get => (QueryBuilderParameter<string?>?)_text.Value;
            set => _text = new InputPropertyInfo { Name = "text", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_text.Name != null) yield return _text;
        }
    }
}

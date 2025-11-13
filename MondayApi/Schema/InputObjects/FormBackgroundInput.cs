using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class FormBackgroundInput : IGraphQlInputObject {
        private InputPropertyInfo _type;
        private InputPropertyInfo _value;

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormBackgrounds?>))]
        public QueryBuilderParameter<FormBackgrounds?>? Type {
            get => (QueryBuilderParameter<FormBackgrounds?>?)_type.Value;
            set => _type = new InputPropertyInfo { Name = "type", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Value {
            get => (QueryBuilderParameter<string?>?)_value.Value;
            set => _value = new InputPropertyInfo { Name = "value", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_type.Name != null) yield return _type;
            if (_value.Name != null) yield return _value;
        }
    }
}

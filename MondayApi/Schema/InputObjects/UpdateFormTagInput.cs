using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UpdateFormTagInput : IGraphQlInputObject {
        private InputPropertyInfo _value;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Value {
            get => (QueryBuilderParameter<string?>?)_value.Value;
            set => _value = new InputPropertyInfo { Name = "value", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_value.Name != null) yield return _value;
        }
    }
}

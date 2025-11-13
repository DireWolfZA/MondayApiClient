using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class StatusCalculatedCapabilityInput : IGraphQlInputObject {
        private InputPropertyInfo _function;

        [JsonConverter(typeof(QueryBuilderParameterConverter<StatusCalculatedFunction?>))]
        public QueryBuilderParameter<StatusCalculatedFunction?>? Function {
            get => (QueryBuilderParameter<StatusCalculatedFunction?>?)_function.Value;
            set => _function = new InputPropertyInfo { Name = "function", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_function.Name != null) yield return _function;
        }
    }
}

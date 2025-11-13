using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CalculatedCapabilityInput : IGraphQlInputObject {
        private InputPropertyInfo _function;

        [JsonConverter(typeof(QueryBuilderParameterConverter<CalculatedFunction?>))]
        public QueryBuilderParameter<CalculatedFunction?>? Function {
            get => (QueryBuilderParameter<CalculatedFunction?>?)_function.Value;
            set => _function = new InputPropertyInfo { Name = "function", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_function.Name != null) yield return _function;
        }
    }
}

using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AggregateSelectFunctionInput : IGraphQlInputObject {
        private InputPropertyInfo _function;
        private InputPropertyInfo _params;

        [JsonConverter(typeof(QueryBuilderParameterConverter<AggregateSelectFunctionName?>))]
        public QueryBuilderParameter<AggregateSelectFunctionName?>? Function {
            get => (QueryBuilderParameter<AggregateSelectFunctionName?>?)_function.Value;
            set => _function = new InputPropertyInfo { Name = "function", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<AggregateSelectElementInput>?>))]
        public QueryBuilderParameter<ICollection<AggregateSelectElementInput>?>? Params {
            get => (QueryBuilderParameter<ICollection<AggregateSelectElementInput>?>?)_params.Value;
            set => _params = new InputPropertyInfo { Name = "params", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_function.Name != null) yield return _function;
            if (_params.Name != null) yield return _params;
        }
    }
}

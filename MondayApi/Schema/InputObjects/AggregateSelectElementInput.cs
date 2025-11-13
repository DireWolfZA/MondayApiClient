using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AggregateSelectElementInput : IGraphQlInputObject {
        private InputPropertyInfo _type;
        private InputPropertyInfo _column;
        private InputPropertyInfo _function;
        private InputPropertyInfo _as;

        [JsonConverter(typeof(QueryBuilderParameterConverter<AggregateSelectElementType?>))]
        public QueryBuilderParameter<AggregateSelectElementType?>? Type {
            get => (QueryBuilderParameter<AggregateSelectElementType?>?)_type.Value;
            set => _type = new InputPropertyInfo { Name = "type", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<AggregateSelectColumnInput?>))]
        public QueryBuilderParameter<AggregateSelectColumnInput?>? Column {
            get => (QueryBuilderParameter<AggregateSelectColumnInput?>?)_column.Value;
            set => _column = new InputPropertyInfo { Name = "column", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<AggregateSelectFunctionInput?>))]
        public QueryBuilderParameter<AggregateSelectFunctionInput?>? Function {
            get => (QueryBuilderParameter<AggregateSelectFunctionInput?>?)_function.Value;
            set => _function = new InputPropertyInfo { Name = "function", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? As {
            get => (QueryBuilderParameter<string?>?)_as.Value;
            set => _as = new InputPropertyInfo { Name = "as", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_type.Name != null) yield return _type;
            if (_column.Name != null) yield return _column;
            if (_function.Name != null) yield return _function;
            if (_as.Name != null) yield return _as;
        }
    }
}

using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ItemsQueryRule : IGraphQlInputObject {
        private InputPropertyInfo _columnID;
        private InputPropertyInfo _compareValue;
        private InputPropertyInfo _compareAttribute;
        private InputPropertyInfo _operator;

        [JsonProperty("column_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string>))]
        public QueryBuilderParameter<string> ColumnID {
            get => (QueryBuilderParameter<string>)_columnID.Value;
            set => _columnID = new InputPropertyInfo { Name = "column_id", Value = value };
        }

        [JsonProperty("compare_value")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<object>))]
        public QueryBuilderParameter<object> CompareValue {
            get => (QueryBuilderParameter<object>)_compareValue.Value;
            set => _compareValue = new InputPropertyInfo { Name = "compare_value", Value = value };
        }

        [JsonProperty("compare_attribute")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string>))]
        public QueryBuilderParameter<string> CompareAttribute {
            get => (QueryBuilderParameter<string>)_compareAttribute.Value;
            set => _compareAttribute = new InputPropertyInfo { Name = "compare_attribute", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<ItemsQueryRuleOperator?>))]
        public QueryBuilderParameter<ItemsQueryRuleOperator?> Operator {
            get => (QueryBuilderParameter<ItemsQueryRuleOperator?>)_operator.Value;
            set => _operator = new InputPropertyInfo { Name = "operator", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_columnID.Name != null) yield return _columnID;
            if (_compareValue.Name != null) yield return _compareValue;
            if (_compareAttribute.Name != null) yield return _compareAttribute;
            if (_operator.Name != null) yield return _operator;
        }
    }
}

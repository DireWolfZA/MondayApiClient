using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ItemsQueryGroup : IGraphQlInputObject {
        private InputPropertyInfo _rules;
        private InputPropertyInfo _groups;
        private InputPropertyInfo _operator;

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<ItemsQueryRule>>))]
        public QueryBuilderParameter<ICollection<ItemsQueryRule>> Rules {
            get => (QueryBuilderParameter<ICollection<ItemsQueryRule>>)_rules.Value;
            set => _rules = new InputPropertyInfo { Name = "rules", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<ItemsQueryGroup>>))]
        public QueryBuilderParameter<ICollection<ItemsQueryGroup>> Groups {
            get => (QueryBuilderParameter<ICollection<ItemsQueryGroup>>)_groups.Value;
            set => _groups = new InputPropertyInfo { Name = "groups", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<ItemsQueryOperator?>))]
        public QueryBuilderParameter<ItemsQueryOperator?> Operator {
            get => (QueryBuilderParameter<ItemsQueryOperator?>)_operator.Value;
            set => _operator = new InputPropertyInfo { Name = "operator", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_rules.Name != null) yield return _rules;
            if (_groups.Name != null) yield return _groups;
            if (_operator.Name != null) yield return _operator;
        }
    }
}

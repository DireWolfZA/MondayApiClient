using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ItemsQuery : IGraphQlInputObject {
        private InputPropertyInfo _rules;
        private InputPropertyInfo _ids;
        private InputPropertyInfo _operator;
        private InputPropertyInfo _orderBy;

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<ItemsQueryRule>>))]
        public QueryBuilderParameter<ICollection<ItemsQueryRule>> Rules {
            get => (QueryBuilderParameter<ICollection<ItemsQueryRule>>)_rules.Value;
            set => _rules = new InputPropertyInfo { Name = "rules", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<Guid>>))]
        public QueryBuilderParameter<ICollection<Guid>> Ids {
            get => (QueryBuilderParameter<ICollection<Guid>>)_ids.Value;
            set => _ids = new InputPropertyInfo { Name = "ids", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<ItemsQueryOperator?>))]
        public QueryBuilderParameter<ItemsQueryOperator?> Operator {
            get => (QueryBuilderParameter<ItemsQueryOperator?>)_operator.Value;
            set => _operator = new InputPropertyInfo { Name = "operator", Value = value };
        }

        [JsonProperty("order_by")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<ItemsQueryOrderBy>>))]
        public QueryBuilderParameter<ICollection<ItemsQueryOrderBy>> OrderBy {
            get => (QueryBuilderParameter<ICollection<ItemsQueryOrderBy>>)_orderBy.Value;
            set => _orderBy = new InputPropertyInfo { Name = "order_by", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_rules.Name != null) yield return _rules;
            if (_ids.Name != null) yield return _ids;
            if (_operator.Name != null) yield return _operator;
            if (_orderBy.Name != null) yield return _orderBy;
        }
    }
}

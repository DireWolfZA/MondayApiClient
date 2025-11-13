using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AggregateQueryInput : IGraphQlInputObject {
        private InputPropertyInfo _select;
        private InputPropertyInfo _from;
        private InputPropertyInfo _groupBy;
        private InputPropertyInfo _query;
        private InputPropertyInfo _limit;

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<AggregateSelectElementInput>?>))]
        public QueryBuilderParameter<ICollection<AggregateSelectElementInput>?>? Select {
            get => (QueryBuilderParameter<ICollection<AggregateSelectElementInput>?>?)_select.Value;
            set => _select = new InputPropertyInfo { Name = "select", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<AggregateFromTableInput?>))]
        public QueryBuilderParameter<AggregateFromTableInput?>? From {
            get => (QueryBuilderParameter<AggregateFromTableInput?>?)_from.Value;
            set => _from = new InputPropertyInfo { Name = "from", Value = value };
        }

        [JsonProperty("group_by")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<AggregateGroupByElementInput>?>))]
        public QueryBuilderParameter<ICollection<AggregateGroupByElementInput>?>? GroupBy {
            get => (QueryBuilderParameter<ICollection<AggregateGroupByElementInput>?>?)_groupBy.Value;
            set => _groupBy = new InputPropertyInfo { Name = "group_by", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<ItemsQuery?>))]
        public QueryBuilderParameter<ItemsQuery?>? Query {
            get => (QueryBuilderParameter<ItemsQuery?>?)_query.Value;
            set => _query = new InputPropertyInfo { Name = "query", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        public QueryBuilderParameter<int?>? Limit {
            get => (QueryBuilderParameter<int?>?)_limit.Value;
            set => _limit = new InputPropertyInfo { Name = "limit", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_select.Name != null) yield return _select;
            if (_from.Name != null) yield return _from;
            if (_groupBy.Name != null) yield return _groupBy;
            if (_query.Name != null) yield return _query;
            if (_limit.Name != null) yield return _limit;
        }
    }
}

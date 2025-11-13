using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class MarketplaceAiSearchInput : IGraphQlInputObject {
        private InputPropertyInfo _query;
        private InputPropertyInfo _limit;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Query {
            get => (QueryBuilderParameter<string?>?)_query.Value;
            set => _query = new InputPropertyInfo { Name = "query", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        public QueryBuilderParameter<int?>? Limit {
            get => (QueryBuilderParameter<int?>?)_limit.Value;
            set => _limit = new InputPropertyInfo { Name = "limit", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_query.Name != null) yield return _query;
            if (_limit.Name != null) yield return _limit;
        }
    }
}

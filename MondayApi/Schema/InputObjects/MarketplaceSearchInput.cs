using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class MarketplaceSearchInput : IGraphQlInputObject {
        private InputPropertyInfo _query;
        private InputPropertyInfo _limit;
        private InputPropertyInfo _offset;

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

        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        public QueryBuilderParameter<int?>? Offset {
            get => (QueryBuilderParameter<int?>?)_offset.Value;
            set => _offset = new InputPropertyInfo { Name = "offset", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_query.Name != null) yield return _query;
            if (_limit.Name != null) yield return _limit;
            if (_offset.Name != null) yield return _offset;
        }
    }
}

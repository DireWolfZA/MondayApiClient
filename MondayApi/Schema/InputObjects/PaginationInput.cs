using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class PaginationInput : IGraphQlInputObject {
        private InputPropertyInfo _limit;
        private InputPropertyInfo _lastID;

        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        public QueryBuilderParameter<int?>? Limit {
            get => (QueryBuilderParameter<int?>?)_limit.Value;
            set => _limit = new InputPropertyInfo { Name = "limit", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        public QueryBuilderParameter<int?>? LastID {
            get => (QueryBuilderParameter<int?>?)_lastID.Value;
            set => _lastID = new InputPropertyInfo { Name = "lastId", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_limit.Name != null) yield return _limit;
            if (_lastID.Name != null) yield return _lastID;
        }
    }
}

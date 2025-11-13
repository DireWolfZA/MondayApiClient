using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AggregateGroupByElementInput : IGraphQlInputObject {
        private InputPropertyInfo _columnID;
        private InputPropertyInfo _limit;

        [JsonProperty("column_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? ColumnID {
            get => (QueryBuilderParameter<string?>?)_columnID.Value;
            set => _columnID = new InputPropertyInfo { Name = "column_id", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        public QueryBuilderParameter<int?>? Limit {
            get => (QueryBuilderParameter<int?>?)_limit.Value;
            set => _limit = new InputPropertyInfo { Name = "limit", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_columnID.Name != null) yield return _columnID;
            if (_limit.Name != null) yield return _limit;
        }
    }
}

using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class FormResponseLimitInput : IGraphQlInputObject {
        private InputPropertyInfo _enabled;
        private InputPropertyInfo _limit;

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? Enabled {
            get => (QueryBuilderParameter<bool?>?)_enabled.Value;
            set => _enabled = new InputPropertyInfo { Name = "enabled", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        public QueryBuilderParameter<int?>? Limit {
            get => (QueryBuilderParameter<int?>?)_limit.Value;
            set => _limit = new InputPropertyInfo { Name = "limit", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_enabled.Name != null) yield return _enabled;
            if (_limit.Name != null) yield return _limit;
        }
    }
}

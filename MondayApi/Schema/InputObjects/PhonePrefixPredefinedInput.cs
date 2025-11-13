using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class PhonePrefixPredefinedInput : IGraphQlInputObject {
        private InputPropertyInfo _enabled;
        private InputPropertyInfo _prefix;

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? Enabled {
            get => (QueryBuilderParameter<bool?>?)_enabled.Value;
            set => _enabled = new InputPropertyInfo { Name = "enabled", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Prefix {
            get => (QueryBuilderParameter<string?>?)_prefix.Value;
            set => _prefix = new InputPropertyInfo { Name = "prefix", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_enabled.Name != null) yield return _enabled;
            if (_prefix.Name != null) yield return _prefix;
        }
    }
}

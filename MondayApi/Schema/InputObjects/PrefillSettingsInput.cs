using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class PrefillSettingsInput : IGraphQlInputObject {
        private InputPropertyInfo _enabled;
        private InputPropertyInfo _source;
        private InputPropertyInfo _lookup;

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? Enabled {
            get => (QueryBuilderParameter<bool?>?)_enabled.Value;
            set => _enabled = new InputPropertyInfo { Name = "enabled", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FormQuestionPrefillSources?>))]
        public QueryBuilderParameter<FormQuestionPrefillSources?>? Source {
            get => (QueryBuilderParameter<FormQuestionPrefillSources?>?)_source.Value;
            set => _source = new InputPropertyInfo { Name = "source", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Lookup {
            get => (QueryBuilderParameter<string?>?)_lookup.Value;
            set => _lookup = new InputPropertyInfo { Name = "lookup", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_enabled.Name != null) yield return _enabled;
            if (_source.Name != null) yield return _source;
            if (_lookup.Name != null) yield return _lookup;
        }
    }
}

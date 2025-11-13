using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class FormCloseDateInput : IGraphQlInputObject {
        private InputPropertyInfo _enabled;
        private InputPropertyInfo _date;

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? Enabled {
            get => (QueryBuilderParameter<bool?>?)_enabled.Value;
            set => _enabled = new InputPropertyInfo { Name = "enabled", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Date {
            get => (QueryBuilderParameter<string?>?)_date.Value;
            set => _date = new InputPropertyInfo { Name = "date", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_enabled.Name != null) yield return _enabled;
            if (_date.Name != null) yield return _date;
        }
    }
}

using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class FormPasswordInput : IGraphQlInputObject {
        private InputPropertyInfo _enabled;

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? Enabled {
            get => (QueryBuilderParameter<bool?>?)_enabled.Value;
            set => _enabled = new InputPropertyInfo { Name = "enabled", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_enabled.Name != null) yield return _enabled;
        }
    }
}

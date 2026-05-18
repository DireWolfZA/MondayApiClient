using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class DependencyPulseValueInput : IGraphQlInputObject {
        private InputPropertyInfo _pulseID;
        private InputPropertyInfo _value;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? PulseID {
            get => (QueryBuilderParameter<string?>?)_pulseID.Value;
            set => _pulseID = new InputPropertyInfo { Name = "pulseId", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<DependencyValueInput?>))]
        public QueryBuilderParameter<DependencyValueInput?>? Value {
            get => (QueryBuilderParameter<DependencyValueInput?>?)_value.Value;
            set => _value = new InputPropertyInfo { Name = "value", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_pulseID.Name != null) yield return _pulseID;
            if (_value.Name != null) yield return _value;
        }
    }
}

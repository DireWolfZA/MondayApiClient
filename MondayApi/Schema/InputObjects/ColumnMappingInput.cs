using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ColumnMappingInput : IGraphQlInputObject {
        private InputPropertyInfo _source;
        private InputPropertyInfo _target;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Source {
            get => (QueryBuilderParameter<string?>?)_source.Value;
            set => _source = new InputPropertyInfo { Name = "source", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Target {
            get => (QueryBuilderParameter<string?>?)_target.Value;
            set => _target = new InputPropertyInfo { Name = "target", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_source.Name != null) yield return _source;
            if (_target.Name != null) yield return _target;
        }
    }
}

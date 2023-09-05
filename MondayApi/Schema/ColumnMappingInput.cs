using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ColumnMappingInput : IGraphQlInputObject {
        private InputPropertyInfo _source;
        private InputPropertyInfo _target;

        [JsonConverter(typeof(QueryBuilderParameterConverter<Guid?>))]
        public QueryBuilderParameter<Guid?> Source {
            get => (QueryBuilderParameter<Guid?>)_source.Value;
            set => _source = new InputPropertyInfo { Name = "source", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<Guid?>))]
        public QueryBuilderParameter<Guid?> Target {
            get => (QueryBuilderParameter<Guid?>)_target.Value;
            set => _target = new InputPropertyInfo { Name = "target", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_source.Name != null) yield return _source;
            if (_target.Name != null) yield return _target;
        }
    }
}

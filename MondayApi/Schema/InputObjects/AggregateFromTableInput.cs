using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AggregateFromTableInput : IGraphQlInputObject {
        private InputPropertyInfo _type;
        private InputPropertyInfo _id;

        [JsonConverter(typeof(QueryBuilderParameterConverter<AggregateFromElementType?>))]
        public QueryBuilderParameter<AggregateFromElementType?>? Type {
            get => (QueryBuilderParameter<AggregateFromElementType?>?)_type.Value;
            set => _type = new InputPropertyInfo { Name = "type", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? ID {
            get => (QueryBuilderParameter<string?>?)_id.Value;
            set => _id = new InputPropertyInfo { Name = "id", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_type.Name != null) yield return _type;
            if (_id.Name != null) yield return _id;
        }
    }
}

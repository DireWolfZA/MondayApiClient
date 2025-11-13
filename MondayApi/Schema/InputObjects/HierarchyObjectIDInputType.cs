using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class HierarchyObjectIDInputType : IGraphQlInputObject {
        private InputPropertyInfo _id;
        private InputPropertyInfo _type;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? ID {
            get => (QueryBuilderParameter<string?>?)_id.Value;
            set => _id = new InputPropertyInfo { Name = "id", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<GraphqlMondayObject?>))]
        public QueryBuilderParameter<GraphqlMondayObject?>? Type {
            get => (QueryBuilderParameter<GraphqlMondayObject?>?)_type.Value;
            set => _type = new InputPropertyInfo { Name = "type", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_id.Name != null) yield return _id;
            if (_type.Name != null) yield return _type;
        }
    }
}

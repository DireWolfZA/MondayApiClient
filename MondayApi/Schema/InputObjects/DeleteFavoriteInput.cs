using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class DeleteFavoriteInput : IGraphQlInputObject {
        private InputPropertyInfo _object;

        [JsonConverter(typeof(QueryBuilderParameterConverter<HierarchyObjectIDInputType?>))]
        public QueryBuilderParameter<HierarchyObjectIDInputType?>? Object {
            get => (QueryBuilderParameter<HierarchyObjectIDInputType?>?)_object.Value;
            set => _object = new InputPropertyInfo { Name = "object", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_object.Name != null) yield return _object;
        }
    }
}

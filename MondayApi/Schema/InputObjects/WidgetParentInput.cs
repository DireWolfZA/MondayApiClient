using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class WidgetParentInput : IGraphQlInputObject {
        private InputPropertyInfo _kind;
        private InputPropertyInfo _id;

        [JsonConverter(typeof(QueryBuilderParameterConverter<WidgetParentKind?>))]
        public QueryBuilderParameter<WidgetParentKind?>? Kind {
            get => (QueryBuilderParameter<WidgetParentKind?>?)_kind.Value;
            set => _kind = new InputPropertyInfo { Name = "kind", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? ID {
            get => (QueryBuilderParameter<string?>?)_id.Value;
            set => _id = new InputPropertyInfo { Name = "id", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_kind.Name != null) yield return _kind;
            if (_id.Name != null) yield return _id;
        }
    }
}

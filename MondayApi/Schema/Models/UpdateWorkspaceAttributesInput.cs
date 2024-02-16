using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UpdateWorkspaceAttributesInput : IGraphQlInputObject {
        private InputPropertyInfo _name;
        private InputPropertyInfo _description;
        private InputPropertyInfo _kind;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string>))]
        public QueryBuilderParameter<string> Name {
            get => (QueryBuilderParameter<string>)_name.Value;
            set => _name = new InputPropertyInfo { Name = "name", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string>))]
        public QueryBuilderParameter<string> Description {
            get => (QueryBuilderParameter<string>)_description.Value;
            set => _description = new InputPropertyInfo { Name = "description", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<WorkspaceKind?>))]
        public QueryBuilderParameter<WorkspaceKind?> Kind {
            get => (QueryBuilderParameter<WorkspaceKind?>)_kind.Value;
            set => _kind = new InputPropertyInfo { Name = "kind", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_name.Name != null)
                yield return _name;
            if (_description.Name != null)
                yield return _description;
            if (_kind.Name != null)
                yield return _kind;
        }
    }
}

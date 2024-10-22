using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CreateDocWorkspaceInput : IGraphQlInputObject {
        private InputPropertyInfo _kind;
        private InputPropertyInfo _name;
        private InputPropertyInfo _workspaceID;

        [JsonConverter(typeof(QueryBuilderParameterConverter<BoardKind?>))]
        public QueryBuilderParameter<BoardKind?> Kind {
            get => (QueryBuilderParameter<BoardKind?>)_kind.Value;
            set => _kind = new InputPropertyInfo { Name = "kind", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string>))]
        public QueryBuilderParameter<string> Name {
            get => (QueryBuilderParameter<string>)_name.Value;
            set => _name = new InputPropertyInfo { Name = "name", Value = value };
        }

        [JsonProperty("workspace_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string>))]
        public QueryBuilderParameter<string> WorkspaceID {
            get => (QueryBuilderParameter<string>)_workspaceID.Value;
            set => _workspaceID = new InputPropertyInfo { Name = "workspace_id", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_kind.Name != null) yield return _kind;
            if (_name.Name != null) yield return _name;
            if (_workspaceID.Name != null) yield return _workspaceID;
        }
    }
}

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CreateDocWorkspaceInput : IGraphQlInputObject {
        private InputPropertyInfo _workspaceId;
        private InputPropertyInfo _kind;
        private InputPropertyInfo _name;

        [JsonProperty("workspace_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<Guid?>))]
        public QueryBuilderParameter<Guid?> WorkspaceId {
            get { return (QueryBuilderParameter<Guid?>)_workspaceId.Value; }
            set { _workspaceId = new InputPropertyInfo { Name = "workspace_id", Value = value }; }
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<BoardKind?>))]
        public QueryBuilderParameter<BoardKind?> Kind {
            get { return (QueryBuilderParameter<BoardKind?>)_kind.Value; }
            set { _kind = new InputPropertyInfo { Name = "kind", Value = value }; }
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string>))]
        public QueryBuilderParameter<string> Name {
            get { return (QueryBuilderParameter<string>)_name.Value; }
            set { _name = new InputPropertyInfo { Name = "name", Value = value }; }
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_workspaceId.Name != null) yield return _workspaceId;
            if (_kind.Name != null) yield return _kind;
            if (_name.Name != null) yield return _name;
        }
    }
}

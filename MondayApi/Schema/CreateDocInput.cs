using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CreateDocInput : IGraphQlInputObject {
        private InputPropertyInfo _board;
        private InputPropertyInfo _workspace;

        [JsonConverter(typeof(QueryBuilderParameterConverter<CreateDocBoardInput>))]
        public QueryBuilderParameter<CreateDocBoardInput> Board {
            get { return (QueryBuilderParameter<CreateDocBoardInput>)_board.Value; }
            set { _board = new InputPropertyInfo { Name = "board", Value = value }; }
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<CreateDocWorkspaceInput>))]
        public QueryBuilderParameter<CreateDocWorkspaceInput> Workspace {
            get { return (QueryBuilderParameter<CreateDocWorkspaceInput>)_workspace.Value; }
            set { _workspace = new InputPropertyInfo { Name = "workspace", Value = value }; }
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_board.Name != null) yield return _board;
            if (_workspace.Name != null) yield return _workspace;
        }
    }
}

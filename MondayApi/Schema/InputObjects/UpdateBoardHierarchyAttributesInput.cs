using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UpdateBoardHierarchyAttributesInput : IGraphQlInputObject {
        private InputPropertyInfo _accountProductID;
        private InputPropertyInfo _folderID;
        private InputPropertyInfo _position;
        private InputPropertyInfo _workspaceID;

        [JsonProperty("account_product_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? AccountProductID {
            get => (QueryBuilderParameter<string?>?)_accountProductID.Value;
            set => _accountProductID = new InputPropertyInfo { Name = "account_product_id", Value = value };
        }

        [JsonProperty("folder_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? FolderID {
            get => (QueryBuilderParameter<string?>?)_folderID.Value;
            set => _folderID = new InputPropertyInfo { Name = "folder_id", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<DynamicPosition?>))]
        public QueryBuilderParameter<DynamicPosition?>? Position {
            get => (QueryBuilderParameter<DynamicPosition?>?)_position.Value;
            set => _position = new InputPropertyInfo { Name = "position", Value = value };
        }

        [JsonProperty("workspace_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? WorkspaceID {
            get => (QueryBuilderParameter<string?>?)_workspaceID.Value;
            set => _workspaceID = new InputPropertyInfo { Name = "workspace_id", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_accountProductID.Name != null) yield return _accountProductID;
            if (_folderID.Name != null) yield return _folderID;
            if (_position.Name != null) yield return _position;
            if (_workspaceID.Name != null) yield return _workspaceID;
        }
    }
}

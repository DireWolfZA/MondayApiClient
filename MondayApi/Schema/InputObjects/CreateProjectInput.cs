using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CreateProjectInput : IGraphQlInputObject {
        private InputPropertyInfo _name;
        private InputPropertyInfo _boardKind;
        private InputPropertyInfo _templateID;
        private InputPropertyInfo _companions;
        private InputPropertyInfo _workspaceID;
        private InputPropertyInfo _folderID;
        private InputPropertyInfo _callbackURL;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Name {
            get => (QueryBuilderParameter<string?>?)_name.Value;
            set => _name = new InputPropertyInfo { Name = "name", Value = value };
        }

        [JsonProperty("board_kind")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<BoardKind?>))]
        public QueryBuilderParameter<BoardKind?>? BoardKind {
            get => (QueryBuilderParameter<BoardKind?>?)_boardKind.Value;
            set => _boardKind = new InputPropertyInfo { Name = "board_kind", Value = value };
        }

        [JsonProperty("template_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? TemplateID {
            get => (QueryBuilderParameter<string?>?)_templateID.Value;
            set => _templateID = new InputPropertyInfo { Name = "template_id", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<string>?>))]
        public QueryBuilderParameter<ICollection<string>?>? Companions {
            get => (QueryBuilderParameter<ICollection<string>?>?)_companions.Value;
            set => _companions = new InputPropertyInfo { Name = "companions", Value = value };
        }

        [JsonProperty("workspace_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? WorkspaceID {
            get => (QueryBuilderParameter<string?>?)_workspaceID.Value;
            set => _workspaceID = new InputPropertyInfo { Name = "workspace_id", Value = value };
        }

        [JsonProperty("folder_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? FolderID {
            get => (QueryBuilderParameter<string?>?)_folderID.Value;
            set => _folderID = new InputPropertyInfo { Name = "folder_id", Value = value };
        }

        [JsonProperty("callback_url")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? CallbackURL {
            get => (QueryBuilderParameter<string?>?)_callbackURL.Value;
            set => _callbackURL = new InputPropertyInfo { Name = "callback_url", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_name.Name != null) yield return _name;
            if (_boardKind.Name != null) yield return _boardKind;
            if (_templateID.Name != null) yield return _templateID;
            if (_companions.Name != null) yield return _companions;
            if (_workspaceID.Name != null) yield return _workspaceID;
            if (_folderID.Name != null) yield return _folderID;
            if (_callbackURL.Name != null) yield return _callbackURL;
        }
    }
}

using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ConvertBoardToProjectInput : IGraphQlInputObject {
        private InputPropertyInfo _boardID;
        private InputPropertyInfo _columnMappings;
        private InputPropertyInfo _callbackURL;

        [JsonProperty("board_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? BoardID {
            get => (QueryBuilderParameter<string?>?)_boardID.Value;
            set => _boardID = new InputPropertyInfo { Name = "board_id", Value = value };
        }

        [JsonProperty("column_mappings")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<ColumnsMappingInput?>))]
        public QueryBuilderParameter<ColumnsMappingInput?>? ColumnMappings {
            get => (QueryBuilderParameter<ColumnsMappingInput?>?)_columnMappings.Value;
            set => _columnMappings = new InputPropertyInfo { Name = "column_mappings", Value = value };
        }

        [JsonProperty("callback_url")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? CallbackURL {
            get => (QueryBuilderParameter<string?>?)_callbackURL.Value;
            set => _callbackURL = new InputPropertyInfo { Name = "callback_url", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_boardID.Name != null) yield return _boardID;
            if (_columnMappings.Name != null) yield return _columnMappings;
            if (_callbackURL.Name != null) yield return _callbackURL;
        }
    }
}

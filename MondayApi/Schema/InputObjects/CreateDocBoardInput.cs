using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CreateDocBoardInput : IGraphQlInputObject {
        private InputPropertyInfo _itemID;
        private InputPropertyInfo _columnID;

        [JsonProperty("item_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string>))]
        public QueryBuilderParameter<string> ItemID {
            get => (QueryBuilderParameter<string>)_itemID.Value;
            set => _itemID = new InputPropertyInfo { Name = "item_id", Value = value };
        }

        [JsonProperty("column_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string>))]
        public QueryBuilderParameter<string> ColumnID {
            get => (QueryBuilderParameter<string>)_columnID.Value;
            set => _columnID = new InputPropertyInfo { Name = "column_id", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_itemID.Name != null) yield return _itemID;
            if (_columnID.Name != null) yield return _columnID;
        }
    }
}

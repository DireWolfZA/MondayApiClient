using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class CreateDocBoardInput : IGraphQlInputObject {
        private InputPropertyInfo _itemId;
        private InputPropertyInfo _columnId;

        [JsonProperty("item_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<Guid?>))]
        public QueryBuilderParameter<Guid?> ItemId {
            get => (QueryBuilderParameter<Guid?>)_itemId.Value;
            set => _itemId = new InputPropertyInfo { Name = "item_id", Value = value };
        }

        [JsonProperty("column_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string>))]
        public QueryBuilderParameter<string> ColumnId {
            get => (QueryBuilderParameter<string>)_columnId.Value;
            set => _columnId = new InputPropertyInfo { Name = "column_id", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_itemId.Name != null) yield return _itemId;
            if (_columnId.Name != null) yield return _columnId;
        }
    }
}

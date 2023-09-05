using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ItemsQueryOrderBy : IGraphQlInputObject {
        private InputPropertyInfo _columnId;
        private InputPropertyInfo _direction;

        [JsonProperty("column_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string>))]
        public QueryBuilderParameter<string> ColumnId {
            get => (QueryBuilderParameter<string>)_columnId.Value;
            set => _columnId = new InputPropertyInfo { Name = "column_id", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<ItemsOrderByDirection?>))]
        public QueryBuilderParameter<ItemsOrderByDirection?> Direction {
            get => (QueryBuilderParameter<ItemsOrderByDirection?>)_direction.Value;
            set => _direction = new InputPropertyInfo { Name = "direction", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_columnId.Name != null) yield return _columnId;
            if (_direction.Name != null) yield return _direction;
        }
    }
}

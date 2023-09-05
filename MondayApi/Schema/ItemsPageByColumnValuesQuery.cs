using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ItemsPageByColumnValuesQuery : IGraphQlInputObject {
        private InputPropertyInfo _columnId;
        private InputPropertyInfo _columnValues;

        [JsonProperty("column_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string>))]
        public QueryBuilderParameter<string> ColumnId {
            get => (QueryBuilderParameter<string>)_columnId.Value;
            set => _columnId = new InputPropertyInfo { Name = "column_id", Value = value };
        }

        [JsonProperty("column_values")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<string>>))]
        public QueryBuilderParameter<ICollection<string>> ColumnValues {
            get => (QueryBuilderParameter<ICollection<string>>)_columnValues.Value;
            set => _columnValues = new InputPropertyInfo { Name = "column_values", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_columnId.Name != null) yield return _columnId;
            if (_columnValues.Name != null) yield return _columnValues;
        }
    }
}

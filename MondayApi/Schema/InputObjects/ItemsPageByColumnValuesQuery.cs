using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ItemsPageByColumnValuesQuery : IGraphQlInputObject {
        private InputPropertyInfo _columnID;
        private InputPropertyInfo _columnValues;

        [JsonProperty("column_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? ColumnID {
            get => (QueryBuilderParameter<string?>?)_columnID.Value;
            set => _columnID = new InputPropertyInfo { Name = "column_id", Value = value };
        }

        [JsonProperty("column_values")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<string?>?>))]
        public QueryBuilderParameter<ICollection<string?>?>? ColumnValues {
            get => (QueryBuilderParameter<ICollection<string?>?>?)_columnValues.Value;
            set => _columnValues = new InputPropertyInfo { Name = "column_values", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_columnID.Name != null) yield return _columnID;
            if (_columnValues.Name != null) yield return _columnValues;
        }
    }
}

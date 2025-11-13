using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AggregateSelectColumnInput : IGraphQlInputObject {
        private InputPropertyInfo _columnID;

        [JsonProperty("column_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? ColumnID {
            get => (QueryBuilderParameter<string?>?)_columnID.Value;
            set => _columnID = new InputPropertyInfo { Name = "column_id", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_columnID.Name != null) yield return _columnID;
        }
    }
}

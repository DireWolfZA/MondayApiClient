using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ColumnPropertyInput : IGraphQlInputObject {
        private InputPropertyInfo _columnID;
        private InputPropertyInfo _visible;

        [JsonProperty("column_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? ColumnID {
            get => (QueryBuilderParameter<string?>?)_columnID.Value;
            set => _columnID = new InputPropertyInfo { Name = "column_id", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? Visible {
            get => (QueryBuilderParameter<bool?>?)_visible.Value;
            set => _visible = new InputPropertyInfo { Name = "visible", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_columnID.Name != null) yield return _columnID;
            if (_visible.Name != null) yield return _visible;
        }
    }
}

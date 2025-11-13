using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class TableViewSettingsInput : IGraphQlInputObject {
        private InputPropertyInfo _columns;
        private InputPropertyInfo _groupBy;

        [JsonConverter(typeof(QueryBuilderParameterConverter<ColumnsConfigInput?>))]
        public QueryBuilderParameter<ColumnsConfigInput?>? Columns {
            get => (QueryBuilderParameter<ColumnsConfigInput?>?)_columns.Value;
            set => _columns = new InputPropertyInfo { Name = "columns", Value = value };
        }

        [JsonProperty("group_by")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<GroupBySettingsInput?>))]
        public QueryBuilderParameter<GroupBySettingsInput?>? GroupBy {
            get => (QueryBuilderParameter<GroupBySettingsInput?>?)_groupBy.Value;
            set => _groupBy = new InputPropertyInfo { Name = "group_by", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_columns.Name != null) yield return _columns;
            if (_groupBy.Name != null) yield return _groupBy;
        }
    }
}

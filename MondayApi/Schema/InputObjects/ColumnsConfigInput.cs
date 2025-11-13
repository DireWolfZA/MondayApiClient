using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ColumnsConfigInput : IGraphQlInputObject {
        private InputPropertyInfo _columnProperties;
        private InputPropertyInfo _subitemsColumnProperties;
        private InputPropertyInfo _floatingColumnsCount;
        private InputPropertyInfo _columnOrder;

        [JsonProperty("column_properties")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<ColumnPropertyInput>?>))]
        public QueryBuilderParameter<ICollection<ColumnPropertyInput>?>? ColumnProperties {
            get => (QueryBuilderParameter<ICollection<ColumnPropertyInput>?>?)_columnProperties.Value;
            set => _columnProperties = new InputPropertyInfo { Name = "column_properties", Value = value };
        }

        [JsonProperty("subitems_column_properties")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<ColumnPropertyInput>?>))]
        public QueryBuilderParameter<ICollection<ColumnPropertyInput>?>? SubitemsColumnProperties {
            get => (QueryBuilderParameter<ICollection<ColumnPropertyInput>?>?)_subitemsColumnProperties.Value;
            set => _subitemsColumnProperties = new InputPropertyInfo { Name = "subitems_column_properties", Value = value };
        }

        [JsonProperty("floating_columns_count")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        public QueryBuilderParameter<int?>? FloatingColumnsCount {
            get => (QueryBuilderParameter<int?>?)_floatingColumnsCount.Value;
            set => _floatingColumnsCount = new InputPropertyInfo { Name = "floating_columns_count", Value = value };
        }

        [JsonProperty("column_order")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<string>?>))]
        public QueryBuilderParameter<ICollection<string>?>? ColumnOrder {
            get => (QueryBuilderParameter<ICollection<string>?>?)_columnOrder.Value;
            set => _columnOrder = new InputPropertyInfo { Name = "column_order", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_columnProperties.Name != null) yield return _columnProperties;
            if (_subitemsColumnProperties.Name != null) yield return _subitemsColumnProperties;
            if (_floatingColumnsCount.Name != null) yield return _floatingColumnsCount;
            if (_columnOrder.Name != null) yield return _columnOrder;
        }
    }
}

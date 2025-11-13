using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class DeleteFormTagInput : IGraphQlInputObject {
        private InputPropertyInfo _deleteAssociatedColumn;

        [JsonConverter(typeof(QueryBuilderParameterConverter<bool?>))]
        public QueryBuilderParameter<bool?>? DeleteAssociatedColumn {
            get => (QueryBuilderParameter<bool?>?)_deleteAssociatedColumn.Value;
            set => _deleteAssociatedColumn = new InputPropertyInfo { Name = "deleteAssociatedColumn", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_deleteAssociatedColumn.Name != null) yield return _deleteAssociatedColumn;
        }
    }
}

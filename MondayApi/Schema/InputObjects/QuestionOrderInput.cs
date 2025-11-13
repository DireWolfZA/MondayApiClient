using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class QuestionOrderInput : IGraphQlInputObject {
        private InputPropertyInfo _id;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? ID {
            get => (QueryBuilderParameter<string?>?)_id.Value;
            set => _id = new InputPropertyInfo { Name = "id", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_id.Name != null) yield return _id;
        }
    }
}

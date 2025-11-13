using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class MetadataInput : IGraphQlInputObject {
        private InputPropertyInfo _payload;

        [JsonConverter(typeof(QueryBuilderParameterConverter<PayloadInput?>))]
        public QueryBuilderParameter<PayloadInput?>? Payload {
            get => (QueryBuilderParameter<PayloadInput?>?)_payload.Value;
            set => _payload = new InputPropertyInfo { Name = "payload", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_payload.Name != null) yield return _payload;
        }
    }
}

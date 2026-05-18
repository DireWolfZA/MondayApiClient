using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class TimelineDateInput : IGraphQlInputObject {
        private InputPropertyInfo _id;
        private InputPropertyInfo _from;
        private InputPropertyInfo _to;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? ID {
            get => (QueryBuilderParameter<string?>?)_id.Value;
            set => _id = new InputPropertyInfo { Name = "id", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<DateTimeOffset?>))]
        public QueryBuilderParameter<DateTimeOffset?>? From {
            get => (QueryBuilderParameter<DateTimeOffset?>?)_from.Value;
            set => _from = new InputPropertyInfo { Name = "from", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<DateTimeOffset?>))]
        public QueryBuilderParameter<DateTimeOffset?>? To {
            get => (QueryBuilderParameter<DateTimeOffset?>?)_to.Value;
            set => _to = new InputPropertyInfo { Name = "to", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_id.Name != null) yield return _id;
            if (_from.Name != null) yield return _from;
            if (_to.Name != null) yield return _to;
        }
    }
}

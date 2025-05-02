using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class TimelineItemTimeRange : IGraphQlInputObject {
        private InputPropertyInfo _startTimestamp;
        private InputPropertyInfo _endTimestamp;

        [JsonProperty("start_timestamp")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<DateTimeOffset?>))]
        public QueryBuilderParameter<DateTimeOffset?>? StartTimestamp {
            get => (QueryBuilderParameter<DateTimeOffset?>?)_startTimestamp.Value;
            set => _startTimestamp = new InputPropertyInfo { Name = "start_timestamp", Value = value };
        }

        [JsonProperty("end_timestamp")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<DateTimeOffset?>))]
        public QueryBuilderParameter<DateTimeOffset?>? EndTimestamp {
            get => (QueryBuilderParameter<DateTimeOffset?>?)_endTimestamp.Value;
            set => _endTimestamp = new InputPropertyInfo { Name = "end_timestamp", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_startTimestamp.Name != null) yield return _startTimestamp;
            if (_endTimestamp.Name != null) yield return _endTimestamp;
        }
    }
}

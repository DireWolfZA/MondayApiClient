using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class DateRangeInput : IGraphQlInputObject {
        private InputPropertyInfo _startDate;
        private InputPropertyInfo _endDate;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? StartDate {
            get => (QueryBuilderParameter<string?>?)_startDate.Value;
            set => _startDate = new InputPropertyInfo { Name = "startDate", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? EndDate {
            get => (QueryBuilderParameter<string?>?)_endDate.Value;
            set => _endDate = new InputPropertyInfo { Name = "endDate", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_startDate.Name != null) yield return _startDate;
            if (_endDate.Name != null) yield return _endDate;
        }
    }
}

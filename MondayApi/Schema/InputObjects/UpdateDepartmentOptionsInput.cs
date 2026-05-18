using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UpdateDepartmentOptionsInput : IGraphQlInputObject {
        private InputPropertyInfo _name;
        private InputPropertyInfo _reservedSeats;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Name {
            get => (QueryBuilderParameter<string?>?)_name.Value;
            set => _name = new InputPropertyInfo { Name = "name", Value = value };
        }

        [JsonProperty("reserved_seats")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        public QueryBuilderParameter<int?>? ReservedSeats {
            get => (QueryBuilderParameter<int?>?)_reservedSeats.Value;
            set => _reservedSeats = new InputPropertyInfo { Name = "reserved_seats", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_name.Name != null) yield return _name;
            if (_reservedSeats.Name != null) yield return _reservedSeats;
        }
    }
}

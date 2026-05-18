using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class MeetingsFilterInput : IGraphQlInputObject {
        private InputPropertyInfo _ids;
        private InputPropertyInfo _search;
        private InputPropertyInfo _access;

        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<string>?>))]
        public QueryBuilderParameter<ICollection<string>?>? IDs {
            get => (QueryBuilderParameter<ICollection<string>?>?)_ids.Value;
            set => _ids = new InputPropertyInfo { Name = "ids", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Search {
            get => (QueryBuilderParameter<string?>?)_search.Value;
            set => _search = new InputPropertyInfo { Name = "search", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<MeetingAccessFilter?>))]
        public QueryBuilderParameter<MeetingAccessFilter?>? Access {
            get => (QueryBuilderParameter<MeetingAccessFilter?>?)_access.Value;
            set => _access = new InputPropertyInfo { Name = "access", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_ids.Name != null) yield return _ids;
            if (_search.Name != null) yield return _search;
            if (_access.Name != null) yield return _access;
        }
    }
}

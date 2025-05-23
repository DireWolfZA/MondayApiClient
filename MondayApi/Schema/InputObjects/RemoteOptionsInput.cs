using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class RemoteOptionsInput : IGraphQlInputObject {
        private InputPropertyInfo _fieldTypeReferenceID;
        private InputPropertyInfo _dependenciesValues;
        private InputPropertyInfo _credentialsValues;
        private InputPropertyInfo _pageRequestData;
        private InputPropertyInfo _query;
        private InputPropertyInfo _valuesToFetch;

        [JsonConverter(typeof(QueryBuilderParameterConverter<int?>))]
        public QueryBuilderParameter<int?>? FieldTypeReferenceID {
            get => (QueryBuilderParameter<int?>?)_fieldTypeReferenceID.Value;
            set => _fieldTypeReferenceID = new InputPropertyInfo { Name = "fieldTypeReferenceId", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<object?>))]
        public QueryBuilderParameter<object?>? DependenciesValues {
            get => (QueryBuilderParameter<object?>?)_dependenciesValues.Value;
            set => _dependenciesValues = new InputPropertyInfo { Name = "dependenciesValues", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<object?>))]
        public QueryBuilderParameter<object?>? CredentialsValues {
            get => (QueryBuilderParameter<object?>?)_credentialsValues.Value;
            set => _credentialsValues = new InputPropertyInfo { Name = "credentialsValues", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<object?>))]
        public QueryBuilderParameter<object?>? PageRequestData {
            get => (QueryBuilderParameter<object?>?)_pageRequestData.Value;
            set => _pageRequestData = new InputPropertyInfo { Name = "pageRequestData", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Query {
            get => (QueryBuilderParameter<string?>?)_query.Value;
            set => _query = new InputPropertyInfo { Name = "query", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<object?>))]
        public QueryBuilderParameter<object?>? ValuesToFetch {
            get => (QueryBuilderParameter<object?>?)_valuesToFetch.Value;
            set => _valuesToFetch = new InputPropertyInfo { Name = "valuesToFetch", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_fieldTypeReferenceID.Name != null) yield return _fieldTypeReferenceID;
            if (_dependenciesValues.Name != null) yield return _dependenciesValues;
            if (_credentialsValues.Name != null) yield return _credentialsValues;
            if (_pageRequestData.Name != null) yield return _pageRequestData;
            if (_query.Name != null) yield return _query;
            if (_valuesToFetch.Name != null) yield return _valuesToFetch;
        }
    }
}

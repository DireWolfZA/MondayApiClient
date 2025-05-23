using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class FileInput : IGraphQlInputObject {
        private InputPropertyInfo _assetID;
        private InputPropertyInfo _fileType;
        private InputPropertyInfo _linkToFile;
        private InputPropertyInfo _name;
        private InputPropertyInfo _objectID;

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? AssetID {
            get => (QueryBuilderParameter<string?>?)_assetID.Value;
            set => _assetID = new InputPropertyInfo { Name = "assetId", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<FileColumnValue?>))]
        public QueryBuilderParameter<FileColumnValue?>? FileType {
            get => (QueryBuilderParameter<FileColumnValue?>?)_fileType.Value;
            set => _fileType = new InputPropertyInfo { Name = "fileType", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? LinkToFile {
            get => (QueryBuilderParameter<string?>?)_linkToFile.Value;
            set => _linkToFile = new InputPropertyInfo { Name = "linkToFile", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? Name {
            get => (QueryBuilderParameter<string?>?)_name.Value;
            set => _name = new InputPropertyInfo { Name = "name", Value = value };
        }

        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? ObjectID {
            get => (QueryBuilderParameter<string?>?)_objectID.Value;
            set => _objectID = new InputPropertyInfo { Name = "objectId", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_assetID.Name != null) yield return _assetID;
            if (_fileType.Name != null) yield return _fileType;
            if (_linkToFile.Name != null) yield return _linkToFile;
            if (_name.Name != null) yield return _name;
            if (_objectID.Name != null) yield return _objectID;
        }
    }
}

using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class EnrollToSequenceInput : IGraphQlInputObject {
        private InputPropertyInfo _sequenceID;
        private InputPropertyInfo _boardID;
        private InputPropertyInfo _itemIDs;

        [JsonProperty("sequence_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? SequenceID {
            get => (QueryBuilderParameter<string?>?)_sequenceID.Value;
            set => _sequenceID = new InputPropertyInfo { Name = "sequence_id", Value = value };
        }

        [JsonProperty("board_id")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<string?>))]
        public QueryBuilderParameter<string?>? BoardID {
            get => (QueryBuilderParameter<string?>?)_boardID.Value;
            set => _boardID = new InputPropertyInfo { Name = "board_id", Value = value };
        }

        [JsonProperty("item_ids")]
        [JsonConverter(typeof(QueryBuilderParameterConverter<ICollection<string>?>))]
        public QueryBuilderParameter<ICollection<string>?>? ItemIDs {
            get => (QueryBuilderParameter<ICollection<string>?>?)_itemIDs.Value;
            set => _itemIDs = new InputPropertyInfo { Name = "item_ids", Value = value };
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues() {
            if (_sequenceID.Name != null) yield return _sequenceID;
            if (_boardID.Name != null) yield return _boardID;
            if (_itemIDs.Name != null) yield return _itemIDs;
        }
    }
}

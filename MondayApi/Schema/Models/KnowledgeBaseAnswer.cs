using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class KnowledgeBaseAnswer {
        [JsonProperty("raw_snippets")]
        public ICollection<SnippetSearchResult>? RawSnippets { get; set; }
        public string? Answer { get; set; }
    }
}

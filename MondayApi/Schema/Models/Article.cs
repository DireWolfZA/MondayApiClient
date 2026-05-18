using System.Collections.Generic;

namespace MondayApi.Schema {
    public class Article {
        public ArticleMetadata? Metadata { get; set; }
        public ICollection<ArticleBlock>? Blocks { get; set; }
    }
}

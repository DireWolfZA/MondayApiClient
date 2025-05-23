using System.Collections.Generic;

namespace MondayApi.Schema {
    public class BlocksResult {
        public ICollection<Block>? Blocks { get; set; }
    }
}

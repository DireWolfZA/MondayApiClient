using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AuditLogPage {
        public ICollection<AuditLogEntry>? Logs { get; set; }
        public Pagination? Pagination { get; set; }
    }
}

using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DependencyConfig {
        public ICollection<DependencyField>? OrderedMandatoryFields { get; set; }
        public ICollection<DependencyField>? OptionalFields { get; set; }
    }
}

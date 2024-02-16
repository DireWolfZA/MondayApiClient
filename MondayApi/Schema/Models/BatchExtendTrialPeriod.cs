using System.Collections.Generic;

namespace MondayApi.Schema {
    public class BatchExtendTrialPeriod {
        public ICollection<ExtendTrialPeriod> Details { get; set; }
        public string Reason { get; set; }
        public bool? Success { get; set; }
    }
}

using System.Collections.Generic;

namespace MondayApi.Schema {
    public class PolicyDirective : GraphQlDirective {
        public PolicyDirective(QueryBuilderParameter<IEnumerable<object>> policies) : base("policy") {
            AddArgument("policies", policies);
        }
    }
}

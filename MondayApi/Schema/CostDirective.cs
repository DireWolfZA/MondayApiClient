namespace MondayApi.Schema {
    public class CostDirective : GraphQlDirective {
        public CostDirective(QueryBuilderParameter<int> weight) : base("cost") {
            AddArgument("weight", weight);
        }
    }
}

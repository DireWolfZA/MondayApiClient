namespace MondayApi.Schema {
    [GraphQlObjectType("AggregateBasicAggregationResult")]
    public class AggregateBasicAggregationResult : IAggregateResult {
        public decimal? Result { get; set; }
    }
}

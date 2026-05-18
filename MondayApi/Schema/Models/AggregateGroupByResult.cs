namespace MondayApi.Schema {
    [GraphQlObjectType("AggregateGroupByResult")]
    public class AggregateGroupByResult : IAggregateResult {
        public object? Value { get; set; }
    }
}

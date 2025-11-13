using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AggregateBasicAggregationResultQueryBuilder : GraphQlQueryBuilder<AggregateBasicAggregationResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "result" }
        };

        protected override string TypeName => "AggregateBasicAggregationResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AggregateBasicAggregationResultQueryBuilder WithResult(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("result", alias, new GraphQlDirective?[] { include, skip });
        public AggregateBasicAggregationResultQueryBuilder ExceptResult() =>
            ExceptField("result");
    }
}

using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AggregateQueryResultQueryBuilder : GraphQlQueryBuilder<AggregateQueryResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "results", IsComplex = true, QueryBuilderType = typeof(AggregateResultSetQueryBuilder) }
        };

        protected override string TypeName => "AggregateQueryResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AggregateQueryResultQueryBuilder WithResults(AggregateResultSetQueryBuilder aggregateResultSetQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("results", alias, aggregateResultSetQueryBuilder, new GraphQlDirective?[] { include, skip });
        public AggregateQueryResultQueryBuilder ExceptResults() =>
            ExceptField("results");
    }
}

using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AggregateResultSetQueryBuilder : GraphQlQueryBuilder<AggregateResultSetQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "entries", IsComplex = true, QueryBuilderType = typeof(AggregateResultEntryQueryBuilder) }
        };

        protected override string TypeName => "AggregateResultSet";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AggregateResultSetQueryBuilder WithEntries(AggregateResultEntryQueryBuilder aggregateResultEntryQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("entries", alias, aggregateResultEntryQueryBuilder, new GraphQlDirective?[] { include, skip });
        public AggregateResultSetQueryBuilder ExceptEntries() =>
            ExceptField("entries");
    }
}

using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AggregateResultEntryQueryBuilder : GraphQlQueryBuilder<AggregateResultEntryQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "alias" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true, QueryBuilderType = typeof(AggregateResultQueryBuilder) }
        };

        protected override string TypeName => "AggregateResultEntry";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AggregateResultEntryQueryBuilder WithAlias(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("alias", alias, new GraphQlDirective?[] { include, skip });
        public AggregateResultEntryQueryBuilder ExceptAlias() =>
            ExceptField("alias");
        public AggregateResultEntryQueryBuilder WithValue(AggregateResultQueryBuilder aggregateResultQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("value", alias, aggregateResultQueryBuilder, new GraphQlDirective?[] { include, skip });
        public AggregateResultEntryQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}

using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AggregateGroupByResultQueryBuilder : GraphQlQueryBuilder<AggregateGroupByResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "value" }
        };

        protected override string TypeName => "AggregateGroupByResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AggregateGroupByResultQueryBuilder WithValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective?[] { include, skip });
        public AggregateGroupByResultQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}

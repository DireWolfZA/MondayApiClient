using System;
using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AggregateResultQueryBuilder : GraphQlQueryBuilder<AggregateResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = Array.Empty<GraphQlFieldMetadata>();

        public AggregateResultQueryBuilder() => WithTypeName();
        protected override string TypeName => "AggregateResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AggregateResultQueryBuilder WithAggregateBasicAggregationResultFragment(AggregateBasicAggregationResultQueryBuilder aggregateBasicAggregationResultQueryBuilder, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithFragment(aggregateBasicAggregationResultQueryBuilder, new GraphQlDirective?[] { include, skip });
        public AggregateResultQueryBuilder WithAggregateGroupByResultFragment(AggregateGroupByResultQueryBuilder aggregateGroupByResultQueryBuilder, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithFragment(aggregateGroupByResultQueryBuilder, new GraphQlDirective?[] { include, skip });
    }
}

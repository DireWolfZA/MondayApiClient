using System.Collections.Generic;

namespace MondayApi.Schema {
    public class MarketplaceSearchResultsQueryBuilder : GraphQlQueryBuilder<MarketplaceSearchResultsQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "hits", IsComplex = true, QueryBuilderType = typeof(MarketplaceSearchHitQueryBuilder) },
            new GraphQlFieldMetadata { Name = "count" },
            new GraphQlFieldMetadata { Name = "elapsed" }
        };

        protected override string TypeName => "MarketplaceSearchResults";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public MarketplaceSearchResultsQueryBuilder WithHits(MarketplaceSearchHitQueryBuilder marketplaceSearchHitQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("hits", alias, marketplaceSearchHitQueryBuilder, new GraphQlDirective?[] { include, skip });
        public MarketplaceSearchResultsQueryBuilder ExceptHits() =>
            ExceptField("hits");
        public MarketplaceSearchResultsQueryBuilder WithCount(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("count", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceSearchResultsQueryBuilder ExceptCount() =>
            ExceptField("count");
        public MarketplaceSearchResultsQueryBuilder WithElapsed(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("elapsed", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceSearchResultsQueryBuilder ExceptElapsed() =>
            ExceptField("elapsed");
    }
}

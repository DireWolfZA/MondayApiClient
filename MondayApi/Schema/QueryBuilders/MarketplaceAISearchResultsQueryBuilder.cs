using System.Collections.Generic;

namespace MondayApi.Schema {
    public class MarketplaceAISearchResultsQueryBuilder : GraphQlQueryBuilder<MarketplaceAISearchResultsQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "results", IsComplex = true, QueryBuilderType = typeof(MarketplaceAISearchResultQueryBuilder) }
        };

        protected override string TypeName => "MarketplaceAiSearchResults";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public MarketplaceAISearchResultsQueryBuilder WithResults(MarketplaceAISearchResultQueryBuilder marketplaceAISearchResultQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("results", alias, marketplaceAISearchResultQueryBuilder, new GraphQlDirective?[] { include, skip });
        public MarketplaceAISearchResultsQueryBuilder ExceptResults() =>
            ExceptField("results");
    }
}

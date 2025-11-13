using System.Collections.Generic;

namespace MondayApi.Schema {
    public class MarketplaceAISearchResultQueryBuilder : GraphQlQueryBuilder<MarketplaceAISearchResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "marketplace_app_id" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "match_percentage" },
            new GraphQlFieldMetadata { Name = "features", IsComplex = true }
        };

        protected override string TypeName => "MarketplaceAiSearchResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public MarketplaceAISearchResultQueryBuilder WithMarketplaceAppID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("marketplace_app_id", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceAISearchResultQueryBuilder ExceptMarketplaceAppID() =>
            ExceptField("marketplace_app_id");
        public MarketplaceAISearchResultQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceAISearchResultQueryBuilder ExceptName() =>
            ExceptField("name");
        public MarketplaceAISearchResultQueryBuilder WithMatchPercentage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("match_percentage", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceAISearchResultQueryBuilder ExceptMatchPercentage() =>
            ExceptField("match_percentage");
        public MarketplaceAISearchResultQueryBuilder WithFeatures(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("features", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceAISearchResultQueryBuilder ExceptFeatures() =>
            ExceptField("features");
    }
}

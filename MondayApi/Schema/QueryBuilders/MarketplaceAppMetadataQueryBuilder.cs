using System.Collections.Generic;

namespace MondayApi.Schema {
    public class MarketplaceAppMetadataQueryBuilder : GraphQlQueryBuilder<MarketplaceAppMetadataQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "rating" },
            new GraphQlFieldMetadata { Name = "ratingCount" },
            new GraphQlFieldMetadata { Name = "installsCount" }
        };

        protected override string TypeName => "MarketplaceAppMetadata";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public MarketplaceAppMetadataQueryBuilder WithRating(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("rating", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceAppMetadataQueryBuilder ExceptRating() =>
            ExceptField("rating");
        public MarketplaceAppMetadataQueryBuilder WithRatingCount(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("ratingCount", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceAppMetadataQueryBuilder ExceptRatingCount() =>
            ExceptField("ratingCount");
        public MarketplaceAppMetadataQueryBuilder WithInstallsCount(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("installsCount", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceAppMetadataQueryBuilder ExceptInstallsCount() =>
            ExceptField("installsCount");
    }
}

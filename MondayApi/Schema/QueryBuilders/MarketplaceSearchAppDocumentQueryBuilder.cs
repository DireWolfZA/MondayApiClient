using System.Collections.Generic;

namespace MondayApi.Schema {
    public class MarketplaceSearchAppDocumentQueryBuilder : GraphQlQueryBuilder<MarketplaceSearchAppDocumentQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "marketplace_app_id" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "description" },
            new GraphQlFieldMetadata { Name = "short_description" },
            new GraphQlFieldMetadata { Name = "keywords" },
            new GraphQlFieldMetadata { Name = "metadata", IsComplex = true, QueryBuilderType = typeof(MarketplaceAppMetadataQueryBuilder) }
        };

        protected override string TypeName => "MarketplaceSearchAppDocument";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public MarketplaceSearchAppDocumentQueryBuilder WithMarketplaceAppID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("marketplace_app_id", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceSearchAppDocumentQueryBuilder ExceptMarketplaceAppID() =>
            ExceptField("marketplace_app_id");
        public MarketplaceSearchAppDocumentQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceSearchAppDocumentQueryBuilder ExceptName() =>
            ExceptField("name");
        public MarketplaceSearchAppDocumentQueryBuilder WithDescription(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceSearchAppDocumentQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public MarketplaceSearchAppDocumentQueryBuilder WithShortDescription(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("short_description", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceSearchAppDocumentQueryBuilder ExceptShortDescription() =>
            ExceptField("short_description");
        public MarketplaceSearchAppDocumentQueryBuilder WithKeywords(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("keywords", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceSearchAppDocumentQueryBuilder ExceptKeywords() =>
            ExceptField("keywords");
        public MarketplaceSearchAppDocumentQueryBuilder WithMetadata(MarketplaceAppMetadataQueryBuilder marketplaceAppMetadataQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("metadata", alias, marketplaceAppMetadataQueryBuilder, new GraphQlDirective?[] { include, skip });
        public MarketplaceSearchAppDocumentQueryBuilder ExceptMetadata() =>
            ExceptField("metadata");
    }
}

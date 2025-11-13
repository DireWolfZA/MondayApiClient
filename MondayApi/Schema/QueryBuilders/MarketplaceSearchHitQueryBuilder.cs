using System.Collections.Generic;

namespace MondayApi.Schema {
    public class MarketplaceSearchHitQueryBuilder : GraphQlQueryBuilder<MarketplaceSearchHitQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "score" },
            new GraphQlFieldMetadata { Name = "document", IsComplex = true, QueryBuilderType = typeof(MarketplaceSearchAppDocumentQueryBuilder) }
        };

        protected override string TypeName => "MarketplaceSearchHit";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public MarketplaceSearchHitQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceSearchHitQueryBuilder ExceptID() =>
            ExceptField("id");
        public MarketplaceSearchHitQueryBuilder WithScore(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("score", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceSearchHitQueryBuilder ExceptScore() =>
            ExceptField("score");
        public MarketplaceSearchHitQueryBuilder WithDocument(MarketplaceSearchAppDocumentQueryBuilder marketplaceSearchAppDocumentQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("document", alias, marketplaceSearchAppDocumentQueryBuilder, new GraphQlDirective?[] { include, skip });
        public MarketplaceSearchHitQueryBuilder ExceptDocument() =>
            ExceptField("document");
    }
}

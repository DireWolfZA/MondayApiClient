using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DeleteMarketplaceAppDiscountQueryBuilder : GraphQlQueryBuilder<DeleteMarketplaceAppDiscountQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "account_slug" },
            new GraphQlFieldMetadata { Name = "app_id" }
        };

        protected override string TypeName => "DeleteMarketplaceAppDiscount";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DeleteMarketplaceAppDiscountQueryBuilder WithAccountSlug(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("account_slug", alias, new GraphQlDirective[] { include, skip });
        public DeleteMarketplaceAppDiscountQueryBuilder ExceptAccountSlug() =>
            ExceptField("account_slug");
        public DeleteMarketplaceAppDiscountQueryBuilder WithAppID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("app_id", alias, new GraphQlDirective[] { include, skip });
        public DeleteMarketplaceAppDiscountQueryBuilder ExceptAppID() =>
            ExceptField("app_id");
    }
}

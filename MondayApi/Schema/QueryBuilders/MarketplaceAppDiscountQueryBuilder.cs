using System.Collections.Generic;

namespace MondayApi.Schema {
    public class MarketplaceAppDiscountQueryBuilder : GraphQlQueryBuilder<MarketplaceAppDiscountQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "account_slug" },
            new GraphQlFieldMetadata { Name = "account_id" },
            new GraphQlFieldMetadata { Name = "discount" },
            new GraphQlFieldMetadata { Name = "is_recurring" },
            new GraphQlFieldMetadata { Name = "app_plan_ids", IsComplex = true },
            new GraphQlFieldMetadata { Name = "period" },
            new GraphQlFieldMetadata { Name = "valid_until" },
            new GraphQlFieldMetadata { Name = "created_at" }
        };

        protected override string TypeName => "MarketplaceAppDiscount";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public MarketplaceAppDiscountQueryBuilder WithAccountSlug(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("account_slug", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceAppDiscountQueryBuilder ExceptAccountSlug() =>
            ExceptField("account_slug");
        public MarketplaceAppDiscountQueryBuilder WithAccountID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("account_id", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceAppDiscountQueryBuilder ExceptAccountID() =>
            ExceptField("account_id");
        public MarketplaceAppDiscountQueryBuilder WithDiscount(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("discount", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceAppDiscountQueryBuilder ExceptDiscount() =>
            ExceptField("discount");
        public MarketplaceAppDiscountQueryBuilder WithIsRecurring(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("is_recurring", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceAppDiscountQueryBuilder ExceptIsRecurring() =>
            ExceptField("is_recurring");
        public MarketplaceAppDiscountQueryBuilder WithAppPlanIds(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("app_plan_ids", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceAppDiscountQueryBuilder ExceptAppPlanIds() =>
            ExceptField("app_plan_ids");
        public MarketplaceAppDiscountQueryBuilder WithPeriod(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("period", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceAppDiscountQueryBuilder ExceptPeriod() =>
            ExceptField("period");
        public MarketplaceAppDiscountQueryBuilder WithValidUntil(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("valid_until", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceAppDiscountQueryBuilder ExceptValidUntil() =>
            ExceptField("valid_until");
        public MarketplaceAppDiscountQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective?[] { include, skip });
        public MarketplaceAppDiscountQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
    }
}

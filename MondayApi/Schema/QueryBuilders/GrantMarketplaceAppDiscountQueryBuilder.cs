using System.Collections.Generic;

namespace MondayApi.Schema {
    public class GrantMarketplaceAppDiscountQueryBuilder : GraphQlQueryBuilder<GrantMarketplaceAppDiscountQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "days_valid" },
            new GraphQlFieldMetadata { Name = "discount" },
            new GraphQlFieldMetadata { Name = "is_recurring" },
            new GraphQlFieldMetadata { Name = "period" },
            new GraphQlFieldMetadata { Name = "app_plan_ids", IsComplex = true },
            new GraphQlFieldMetadata { Name = "app_id" }
        };

        protected override string TypeName => "GrantMarketplaceAppDiscount";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public GrantMarketplaceAppDiscountQueryBuilder WithDaysValid(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("days_valid", alias, new GraphQlDirective?[] { include, skip });
        public GrantMarketplaceAppDiscountQueryBuilder ExceptDaysValid() =>
            ExceptField("days_valid");
        public GrantMarketplaceAppDiscountQueryBuilder WithDiscount(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("discount", alias, new GraphQlDirective?[] { include, skip });
        public GrantMarketplaceAppDiscountQueryBuilder ExceptDiscount() =>
            ExceptField("discount");
        public GrantMarketplaceAppDiscountQueryBuilder WithIsRecurring(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("is_recurring", alias, new GraphQlDirective?[] { include, skip });
        public GrantMarketplaceAppDiscountQueryBuilder ExceptIsRecurring() =>
            ExceptField("is_recurring");
        public GrantMarketplaceAppDiscountQueryBuilder WithPeriod(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("period", alias, new GraphQlDirective?[] { include, skip });
        public GrantMarketplaceAppDiscountQueryBuilder ExceptPeriod() =>
            ExceptField("period");
        public GrantMarketplaceAppDiscountQueryBuilder WithAppPlanIDs(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("app_plan_ids", alias, new GraphQlDirective?[] { include, skip });
        public GrantMarketplaceAppDiscountQueryBuilder ExceptAppPlanIDs() =>
            ExceptField("app_plan_ids");
        public GrantMarketplaceAppDiscountQueryBuilder WithAppID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("app_id", alias, new GraphQlDirective?[] { include, skip });
        public GrantMarketplaceAppDiscountQueryBuilder ExceptAppID() =>
            ExceptField("app_id");
    }
}

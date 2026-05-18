using System.Collections.Generic;

namespace MondayApi.Schema {
    public class CreateMarketplaceAppDiscountQueryBuilder : GraphQlQueryBuilder<CreateMarketplaceAppDiscountQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "days_valid" },
            new GraphQlFieldMetadata { Name = "discount" },
            new GraphQlFieldMetadata { Name = "is_recurring" },
            new GraphQlFieldMetadata { Name = "period" },
            new GraphQlFieldMetadata { Name = "app_plan_ids", IsComplex = true },
            new GraphQlFieldMetadata { Name = "app_id" }
        };

        protected override string TypeName => "CreateMarketplaceAppDiscount";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public CreateMarketplaceAppDiscountQueryBuilder WithDaysValid(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("days_valid", alias, new GraphQlDirective?[] { include, skip });
        public CreateMarketplaceAppDiscountQueryBuilder ExceptDaysValid() =>
            ExceptField("days_valid");
        public CreateMarketplaceAppDiscountQueryBuilder WithDiscount(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("discount", alias, new GraphQlDirective?[] { include, skip });
        public CreateMarketplaceAppDiscountQueryBuilder ExceptDiscount() =>
            ExceptField("discount");
        public CreateMarketplaceAppDiscountQueryBuilder WithIsRecurring(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("is_recurring", alias, new GraphQlDirective?[] { include, skip });
        public CreateMarketplaceAppDiscountQueryBuilder ExceptIsRecurring() =>
            ExceptField("is_recurring");
        public CreateMarketplaceAppDiscountQueryBuilder WithPeriod(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("period", alias, new GraphQlDirective?[] { include, skip });
        public CreateMarketplaceAppDiscountQueryBuilder ExceptPeriod() =>
            ExceptField("period");
        public CreateMarketplaceAppDiscountQueryBuilder WithAppPlanIDs(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("app_plan_ids", alias, new GraphQlDirective?[] { include, skip });
        public CreateMarketplaceAppDiscountQueryBuilder ExceptAppPlanIDs() =>
            ExceptField("app_plan_ids");
        public CreateMarketplaceAppDiscountQueryBuilder WithAppID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("app_id", alias, new GraphQlDirective?[] { include, skip });
        public CreateMarketplaceAppDiscountQueryBuilder ExceptAppID() =>
            ExceptField("app_id");
    }
}

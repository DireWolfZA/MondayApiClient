using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AppSubscriptionDetailsQueryBuilder : GraphQlQueryBuilder<AppSubscriptionDetailsQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "account_id" },
            new GraphQlFieldMetadata { Name = "plan_id" },
            new GraphQlFieldMetadata { Name = "pricing_version_id" },
            new GraphQlFieldMetadata { Name = "monthly_price" },
            new GraphQlFieldMetadata { Name = "currency" },
            new GraphQlFieldMetadata { Name = "period_type" },
            new GraphQlFieldMetadata { Name = "renewal_date" },
            new GraphQlFieldMetadata { Name = "end_date" },
            new GraphQlFieldMetadata { Name = "status" },
            new GraphQlFieldMetadata { Name = "discounts", IsComplex = true, QueryBuilderType = typeof(SubscriptionDiscountQueryBuilder) },
            new GraphQlFieldMetadata { Name = "days_left" }
        };

        protected override string TypeName => "AppSubscriptionDetails";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AppSubscriptionDetailsQueryBuilder WithAccountID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("account_id", alias, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionDetailsQueryBuilder ExceptAccountID() =>
            ExceptField("account_id");
        public AppSubscriptionDetailsQueryBuilder WithPlanID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("plan_id", alias, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionDetailsQueryBuilder ExceptPlanID() =>
            ExceptField("plan_id");
        public AppSubscriptionDetailsQueryBuilder WithPricingVersionID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("pricing_version_id", alias, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionDetailsQueryBuilder ExceptPricingVersionID() =>
            ExceptField("pricing_version_id");
        public AppSubscriptionDetailsQueryBuilder WithMonthlyPrice(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("monthly_price", alias, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionDetailsQueryBuilder ExceptMonthlyPrice() =>
            ExceptField("monthly_price");
        public AppSubscriptionDetailsQueryBuilder WithCurrency(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("currency", alias, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionDetailsQueryBuilder ExceptCurrency() =>
            ExceptField("currency");
        public AppSubscriptionDetailsQueryBuilder WithPeriodType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("period_type", alias, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionDetailsQueryBuilder ExceptPeriodType() =>
            ExceptField("period_type");
        public AppSubscriptionDetailsQueryBuilder WithRenewalDate(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("renewal_date", alias, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionDetailsQueryBuilder ExceptRenewalDate() =>
            ExceptField("renewal_date");
        public AppSubscriptionDetailsQueryBuilder WithEndDate(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("end_date", alias, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionDetailsQueryBuilder ExceptEndDate() =>
            ExceptField("end_date");
        public AppSubscriptionDetailsQueryBuilder WithStatus(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("status", alias, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionDetailsQueryBuilder ExceptStatus() =>
            ExceptField("status");
        public AppSubscriptionDetailsQueryBuilder WithDiscounts(SubscriptionDiscountQueryBuilder subscriptionDiscountQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("discounts", alias, subscriptionDiscountQueryBuilder, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionDetailsQueryBuilder ExceptDiscounts() =>
            ExceptField("discounts");
        public AppSubscriptionDetailsQueryBuilder WithDaysLeft(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("days_left", alias, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionDetailsQueryBuilder ExceptDaysLeft() =>
            ExceptField("days_left");
    }
}

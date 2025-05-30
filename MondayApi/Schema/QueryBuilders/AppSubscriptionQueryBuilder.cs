using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AppSubscriptionQueryBuilder : GraphQlQueryBuilder<AppSubscriptionQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "billing_period" },
            new GraphQlFieldMetadata { Name = "days_left" },
            new GraphQlFieldMetadata { Name = "is_trial" },
            new GraphQlFieldMetadata { Name = "max_units" },
            new GraphQlFieldMetadata { Name = "plan_id" },
            new GraphQlFieldMetadata { Name = "pricing_version" },
            new GraphQlFieldMetadata { Name = "renewal_date" }
        };

        protected override string TypeName => "AppSubscription";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AppSubscriptionQueryBuilder WithBillingPeriod(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("billing_period", alias, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionQueryBuilder ExceptBillingPeriod() =>
            ExceptField("billing_period");
        public AppSubscriptionQueryBuilder WithDaysLeft(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("days_left", alias, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionQueryBuilder ExceptDaysLeft() =>
            ExceptField("days_left");
        public AppSubscriptionQueryBuilder WithIsTrial(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("is_trial", alias, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionQueryBuilder ExceptIsTrial() =>
            ExceptField("is_trial");
        public AppSubscriptionQueryBuilder WithMaxUnits(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("max_units", alias, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionQueryBuilder ExceptMaxUnits() =>
            ExceptField("max_units");
        public AppSubscriptionQueryBuilder WithPlanID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("plan_id", alias, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionQueryBuilder ExceptPlanID() =>
            ExceptField("plan_id");
        public AppSubscriptionQueryBuilder WithPricingVersion(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("pricing_version", alias, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionQueryBuilder ExceptPricingVersion() =>
            ExceptField("pricing_version");
        public AppSubscriptionQueryBuilder WithRenewalDate(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("renewal_date", alias, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionQueryBuilder ExceptRenewalDate() =>
            ExceptField("renewal_date");
    }
}

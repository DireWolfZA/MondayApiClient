using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AppSubscriptionQueryBuilder : GraphQlQueryBuilder<AppSubscriptionQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "billing_period" },
            new GraphQlFieldMetadata { Name = "days_left" },
            new GraphQlFieldMetadata { Name = "is_trial" },
            new GraphQlFieldMetadata { Name = "plan_id" },
            new GraphQlFieldMetadata { Name = "renewal_date", IsComplex = true }
        };

        protected override string TypeName => "AppSubscription";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AppSubscriptionQueryBuilder WithBillingPeriod(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("billing_period", alias, new GraphQlDirective[] { include, skip });
        public AppSubscriptionQueryBuilder ExceptBillingPeriod() =>
            ExceptField("billing_period");
        public AppSubscriptionQueryBuilder WithDaysLeft(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("days_left", alias, new GraphQlDirective[] { include, skip });
        public AppSubscriptionQueryBuilder ExceptDaysLeft() =>
            ExceptField("days_left");
        public AppSubscriptionQueryBuilder WithIsTrial(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("is_trial", alias, new GraphQlDirective[] { include, skip });
        public AppSubscriptionQueryBuilder ExceptIsTrial() =>
            ExceptField("is_trial");
        public AppSubscriptionQueryBuilder WithPlanId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("plan_id", alias, new GraphQlDirective[] { include, skip });
        public AppSubscriptionQueryBuilder ExceptPlanId() =>
            ExceptField("plan_id");
        public AppSubscriptionQueryBuilder WithRenewalDate(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("renewal_date", alias, new GraphQlDirective[] { include, skip });
        public AppSubscriptionQueryBuilder ExceptRenewalDate() =>
            ExceptField("renewal_date");
    }
}

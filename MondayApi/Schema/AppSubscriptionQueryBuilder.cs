using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AppSubscriptionQueryBuilder : GraphQlQueryBuilder<AppSubscriptionQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new[]
            {
                new GraphQlFieldMetadata { Name = "billing_period" },
                new GraphQlFieldMetadata { Name = "days_left" },
                new GraphQlFieldMetadata { Name = "is_trial" },
                new GraphQlFieldMetadata { Name = "plan_id" },
                new GraphQlFieldMetadata { Name = "renewal_date", IsComplex = true }
            };

        protected override string TypeName { get { return "AppSubscription"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public AppSubscriptionQueryBuilder WithBillingPeriod(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("billing_period", alias, new GraphQlDirective[] { include, skip });
        }

        public AppSubscriptionQueryBuilder ExceptBillingPeriod() {
            return ExceptField("billing_period");
        }

        public AppSubscriptionQueryBuilder WithDaysLeft(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("days_left", alias, new GraphQlDirective[] { include, skip });
        }

        public AppSubscriptionQueryBuilder ExceptDaysLeft() {
            return ExceptField("days_left");
        }

        public AppSubscriptionQueryBuilder WithIsTrial(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("is_trial", alias, new GraphQlDirective[] { include, skip });
        }

        public AppSubscriptionQueryBuilder ExceptIsTrial() {
            return ExceptField("is_trial");
        }

        public AppSubscriptionQueryBuilder WithPlanId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("plan_id", alias, new GraphQlDirective[] { include, skip });
        }

        public AppSubscriptionQueryBuilder ExceptPlanId() {
            return ExceptField("plan_id");
        }

        public AppSubscriptionQueryBuilder WithRenewalDate(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("renewal_date", alias, new GraphQlDirective[] { include, skip });
        }

        public AppSubscriptionQueryBuilder ExceptRenewalDate() {
            return ExceptField("renewal_date");
        }
    }
}

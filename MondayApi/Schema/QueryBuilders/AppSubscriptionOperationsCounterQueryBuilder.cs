using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AppSubscriptionOperationsCounterQueryBuilder : GraphQlQueryBuilder<AppSubscriptionOperationsCounterQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "app_subscription", IsComplex = true, QueryBuilderType = typeof(AppSubscriptionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "counter_value" },
            new GraphQlFieldMetadata { Name = "kind" },
            new GraphQlFieldMetadata { Name = "period_key" }
        };

        protected override string TypeName => "AppSubscriptionOperationsCounter";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AppSubscriptionOperationsCounterQueryBuilder WithAppSubscription(AppSubscriptionQueryBuilder appSubscriptionQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("app_subscription", alias, appSubscriptionQueryBuilder, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionOperationsCounterQueryBuilder ExceptAppSubscription() =>
            ExceptField("app_subscription");
        public AppSubscriptionOperationsCounterQueryBuilder WithCounterValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("counter_value", alias, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionOperationsCounterQueryBuilder ExceptCounterValue() =>
            ExceptField("counter_value");
        public AppSubscriptionOperationsCounterQueryBuilder WithKind(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("kind", alias, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionOperationsCounterQueryBuilder ExceptKind() =>
            ExceptField("kind");
        public AppSubscriptionOperationsCounterQueryBuilder WithPeriodKey(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("period_key", alias, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionOperationsCounterQueryBuilder ExceptPeriodKey() =>
            ExceptField("period_key");
    }
}

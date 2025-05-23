using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AppSubscriptionsQueryBuilder : GraphQlQueryBuilder<AppSubscriptionsQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "subscriptions", IsComplex = true, QueryBuilderType = typeof(AppSubscriptionDetailsQueryBuilder) },
            new GraphQlFieldMetadata { Name = "total_count" },
            new GraphQlFieldMetadata { Name = "cursor" }
        };

        protected override string TypeName => "AppSubscriptions";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AppSubscriptionsQueryBuilder WithSubscriptions(AppSubscriptionDetailsQueryBuilder appSubscriptionDetailsQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("subscriptions", alias, appSubscriptionDetailsQueryBuilder, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionsQueryBuilder ExceptSubscriptions() =>
            ExceptField("subscriptions");
        public AppSubscriptionsQueryBuilder WithTotalCount(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("total_count", alias, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionsQueryBuilder ExceptTotalCount() =>
            ExceptField("total_count");
        public AppSubscriptionsQueryBuilder WithCursor(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("cursor", alias, new GraphQlDirective?[] { include, skip });
        public AppSubscriptionsQueryBuilder ExceptCursor() =>
            ExceptField("cursor");
    }
}

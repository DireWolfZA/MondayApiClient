using System.Collections.Generic;

namespace MondayApi.Schema {
    public class LifecycleSubscriptionKindQueryBuilder : GraphQlQueryBuilder<LifecycleSubscriptionKindQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "entity_id" },
            new GraphQlFieldMetadata { Name = "entity_type" },
            new GraphQlFieldMetadata { Name = "event_type" },
            new GraphQlFieldMetadata { Name = "webhook_url" },
            new GraphQlFieldMetadata { Name = "is_sync" },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "updated_at" }
        };

        protected override string TypeName => "LifecycleSubscriptionKind";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public LifecycleSubscriptionKindQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public LifecycleSubscriptionKindQueryBuilder ExceptID() =>
            ExceptField("id");
        public LifecycleSubscriptionKindQueryBuilder WithEntityID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("entity_id", alias, new GraphQlDirective?[] { include, skip });
        public LifecycleSubscriptionKindQueryBuilder ExceptEntityID() =>
            ExceptField("entity_id");
        public LifecycleSubscriptionKindQueryBuilder WithEntityType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("entity_type", alias, new GraphQlDirective?[] { include, skip });
        public LifecycleSubscriptionKindQueryBuilder ExceptEntityType() =>
            ExceptField("entity_type");
        public LifecycleSubscriptionKindQueryBuilder WithEventType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("event_type", alias, new GraphQlDirective?[] { include, skip });
        public LifecycleSubscriptionKindQueryBuilder ExceptEventType() =>
            ExceptField("event_type");
        public LifecycleSubscriptionKindQueryBuilder WithWebhookURL(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("webhook_url", alias, new GraphQlDirective?[] { include, skip });
        public LifecycleSubscriptionKindQueryBuilder ExceptWebhookURL() =>
            ExceptField("webhook_url");
        public LifecycleSubscriptionKindQueryBuilder WithIsSync(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("is_sync", alias, new GraphQlDirective?[] { include, skip });
        public LifecycleSubscriptionKindQueryBuilder ExceptIsSync() =>
            ExceptField("is_sync");
        public LifecycleSubscriptionKindQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective?[] { include, skip });
        public LifecycleSubscriptionKindQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public LifecycleSubscriptionKindQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective?[] { include, skip });
        public LifecycleSubscriptionKindQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
    }
}

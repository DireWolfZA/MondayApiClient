using System.Collections.Generic;

namespace MondayApi.Schema {
    public class TriggerEventQueryBuilder : GraphQlQueryBuilder<TriggerEventQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "accountId" },
            new GraphQlFieldMetadata { Name = "triggerUuid" },
            new GraphQlFieldMetadata { Name = "eventKind" },
            new GraphQlFieldMetadata { Name = "eventState" },
            new GraphQlFieldMetadata { Name = "triggerStarted" },
            new GraphQlFieldMetadata { Name = "triggerStartedAt" },
            new GraphQlFieldMetadata { Name = "createdAt" },
            new GraphQlFieldMetadata { Name = "errorReason" },
            new GraphQlFieldMetadata { Name = "billingActionsCount" },
            new GraphQlFieldMetadata { Name = "waitingForTriggerName" },
            new GraphQlFieldMetadata { Name = "triggerDuration" },
            new GraphQlFieldMetadata { Name = "entityKind" },
            new GraphQlFieldMetadata { Name = "reignitionSubscriptionId" },
            new GraphQlFieldMetadata { Name = "hostType" },
            new GraphQlFieldMetadata { Name = "hostInstanceId" },
            new GraphQlFieldMetadata { Name = "creatorAppFeatureReferenceId" }
        };

        protected override string TypeName => "TriggerEvent";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public TriggerEventQueryBuilder WithAccountID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("accountId", alias, new GraphQlDirective?[] { include, skip });
        public TriggerEventQueryBuilder ExceptAccountID() =>
            ExceptField("accountId");
        public TriggerEventQueryBuilder WithTriggerUUID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("triggerUuid", alias, new GraphQlDirective?[] { include, skip });
        public TriggerEventQueryBuilder ExceptTriggerUUID() =>
            ExceptField("triggerUuid");
        public TriggerEventQueryBuilder WithEventKind(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("eventKind", alias, new GraphQlDirective?[] { include, skip });
        public TriggerEventQueryBuilder ExceptEventKind() =>
            ExceptField("eventKind");
        public TriggerEventQueryBuilder WithEventState(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("eventState", alias, new GraphQlDirective?[] { include, skip });
        public TriggerEventQueryBuilder ExceptEventState() =>
            ExceptField("eventState");
        public TriggerEventQueryBuilder WithTriggerStarted(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("triggerStarted", alias, new GraphQlDirective?[] { include, skip });
        public TriggerEventQueryBuilder ExceptTriggerStarted() =>
            ExceptField("triggerStarted");
        public TriggerEventQueryBuilder WithTriggerStartedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("triggerStartedAt", alias, new GraphQlDirective?[] { include, skip });
        public TriggerEventQueryBuilder ExceptTriggerStartedAt() =>
            ExceptField("triggerStartedAt");
        public TriggerEventQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("createdAt", alias, new GraphQlDirective?[] { include, skip });
        public TriggerEventQueryBuilder ExceptCreatedAt() =>
            ExceptField("createdAt");
        public TriggerEventQueryBuilder WithErrorReason(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("errorReason", alias, new GraphQlDirective?[] { include, skip });
        public TriggerEventQueryBuilder ExceptErrorReason() =>
            ExceptField("errorReason");
        public TriggerEventQueryBuilder WithBillingActionsCount(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("billingActionsCount", alias, new GraphQlDirective?[] { include, skip });
        public TriggerEventQueryBuilder ExceptBillingActionsCount() =>
            ExceptField("billingActionsCount");
        public TriggerEventQueryBuilder WithWaitingForTriggerName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("waitingForTriggerName", alias, new GraphQlDirective?[] { include, skip });
        public TriggerEventQueryBuilder ExceptWaitingForTriggerName() =>
            ExceptField("waitingForTriggerName");
        public TriggerEventQueryBuilder WithTriggerDuration(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("triggerDuration", alias, new GraphQlDirective?[] { include, skip });
        public TriggerEventQueryBuilder ExceptTriggerDuration() =>
            ExceptField("triggerDuration");
        public TriggerEventQueryBuilder WithEntityKind(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("entityKind", alias, new GraphQlDirective?[] { include, skip });
        public TriggerEventQueryBuilder ExceptEntityKind() =>
            ExceptField("entityKind");
        public TriggerEventQueryBuilder WithReignitionSubscriptionID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("reignitionSubscriptionId", alias, new GraphQlDirective?[] { include, skip });
        public TriggerEventQueryBuilder ExceptReignitionSubscriptionID() =>
            ExceptField("reignitionSubscriptionId");
        public TriggerEventQueryBuilder WithHostType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("hostType", alias, new GraphQlDirective?[] { include, skip });
        public TriggerEventQueryBuilder ExceptHostType() =>
            ExceptField("hostType");
        public TriggerEventQueryBuilder WithHostInstanceID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("hostInstanceId", alias, new GraphQlDirective?[] { include, skip });
        public TriggerEventQueryBuilder ExceptHostInstanceID() =>
            ExceptField("hostInstanceId");
        public TriggerEventQueryBuilder WithCreatorAppFeatureReferenceID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("creatorAppFeatureReferenceId", alias, new GraphQlDirective?[] { include, skip });
        public TriggerEventQueryBuilder ExceptCreatorAppFeatureReferenceID() =>
            ExceptField("creatorAppFeatureReferenceId");
    }
}

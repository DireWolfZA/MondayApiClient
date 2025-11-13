using System.Collections.Generic;

namespace MondayApi.Schema {
    public class BlockEventQueryBuilder : GraphQlQueryBuilder<BlockEventQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "accountId" },
            new GraphQlFieldMetadata { Name = "userId" },
            new GraphQlFieldMetadata { Name = "boardId" },
            new GraphQlFieldMetadata { Name = "eventKind" },
            new GraphQlFieldMetadata { Name = "eventState" },
            new GraphQlFieldMetadata { Name = "triggerUuid" },
            new GraphQlFieldMetadata { Name = "triggerStarted" },
            new GraphQlFieldMetadata { Name = "triggerStartedAt" },
            new GraphQlFieldMetadata { Name = "blockStartTimestamp" },
            new GraphQlFieldMetadata { Name = "blockFinishTimestamp" },
            new GraphQlFieldMetadata { Name = "atomicActionId" },
            new GraphQlFieldMetadata { Name = "title" },
            new GraphQlFieldMetadata { Name = "conditionSatisfied" },
            new GraphQlFieldMetadata { Name = "workflowNodeId" },
            new GraphQlFieldMetadata { Name = "entityKind" },
            new GraphQlFieldMetadata { Name = "billingActionCountForBlock" },
            new GraphQlFieldMetadata { Name = "errorReason" }
        };

        protected override string TypeName => "BlockEvent";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public BlockEventQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public BlockEventQueryBuilder ExceptID() =>
            ExceptField("id");
        public BlockEventQueryBuilder WithAccountID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("accountId", alias, new GraphQlDirective?[] { include, skip });
        public BlockEventQueryBuilder ExceptAccountID() =>
            ExceptField("accountId");
        public BlockEventQueryBuilder WithUserID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("userId", alias, new GraphQlDirective?[] { include, skip });
        public BlockEventQueryBuilder ExceptUserID() =>
            ExceptField("userId");
        public BlockEventQueryBuilder WithBoardID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("boardId", alias, new GraphQlDirective?[] { include, skip });
        public BlockEventQueryBuilder ExceptBoardID() =>
            ExceptField("boardId");
        public BlockEventQueryBuilder WithEventKind(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("eventKind", alias, new GraphQlDirective?[] { include, skip });
        public BlockEventQueryBuilder ExceptEventKind() =>
            ExceptField("eventKind");
        public BlockEventQueryBuilder WithEventState(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("eventState", alias, new GraphQlDirective?[] { include, skip });
        public BlockEventQueryBuilder ExceptEventState() =>
            ExceptField("eventState");
        public BlockEventQueryBuilder WithTriggerUUID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("triggerUuid", alias, new GraphQlDirective?[] { include, skip });
        public BlockEventQueryBuilder ExceptTriggerUUID() =>
            ExceptField("triggerUuid");
        public BlockEventQueryBuilder WithTriggerStarted(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("triggerStarted", alias, new GraphQlDirective?[] { include, skip });
        public BlockEventQueryBuilder ExceptTriggerStarted() =>
            ExceptField("triggerStarted");
        public BlockEventQueryBuilder WithTriggerStartedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("triggerStartedAt", alias, new GraphQlDirective?[] { include, skip });
        public BlockEventQueryBuilder ExceptTriggerStartedAt() =>
            ExceptField("triggerStartedAt");
        public BlockEventQueryBuilder WithBlockStartTimestamp(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("blockStartTimestamp", alias, new GraphQlDirective?[] { include, skip });
        public BlockEventQueryBuilder ExceptBlockStartTimestamp() =>
            ExceptField("blockStartTimestamp");
        public BlockEventQueryBuilder WithBlockFinishTimestamp(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("blockFinishTimestamp", alias, new GraphQlDirective?[] { include, skip });
        public BlockEventQueryBuilder ExceptBlockFinishTimestamp() =>
            ExceptField("blockFinishTimestamp");
        public BlockEventQueryBuilder WithAtomicActionID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("atomicActionId", alias, new GraphQlDirective?[] { include, skip });
        public BlockEventQueryBuilder ExceptAtomicActionID() =>
            ExceptField("atomicActionId");
        public BlockEventQueryBuilder WithTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("title", alias, new GraphQlDirective?[] { include, skip });
        public BlockEventQueryBuilder ExceptTitle() =>
            ExceptField("title");
        public BlockEventQueryBuilder WithConditionSatisfied(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("conditionSatisfied", alias, new GraphQlDirective?[] { include, skip });
        public BlockEventQueryBuilder ExceptConditionSatisfied() =>
            ExceptField("conditionSatisfied");
        public BlockEventQueryBuilder WithWorkflowNodeID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("workflowNodeId", alias, new GraphQlDirective?[] { include, skip });
        public BlockEventQueryBuilder ExceptWorkflowNodeID() =>
            ExceptField("workflowNodeId");
        public BlockEventQueryBuilder WithEntityKind(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("entityKind", alias, new GraphQlDirective?[] { include, skip });
        public BlockEventQueryBuilder ExceptEntityKind() =>
            ExceptField("entityKind");
        public BlockEventQueryBuilder WithBillingActionCountForBlock(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("billingActionCountForBlock", alias, new GraphQlDirective?[] { include, skip });
        public BlockEventQueryBuilder ExceptBillingActionCountForBlock() =>
            ExceptField("billingActionCountForBlock");
        public BlockEventQueryBuilder WithErrorReason(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("errorReason", alias, new GraphQlDirective?[] { include, skip });
        public BlockEventQueryBuilder ExceptErrorReason() =>
            ExceptField("errorReason");
    }
}

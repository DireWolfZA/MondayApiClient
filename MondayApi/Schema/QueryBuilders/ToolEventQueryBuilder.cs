using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ToolEventQueryBuilder : GraphQlQueryBuilder<ToolEventQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "account_id" },
            new GraphQlFieldMetadata { Name = "user_id" },
            new GraphQlFieldMetadata { Name = "trigger_uuid" },
            new GraphQlFieldMetadata { Name = "atomic_action_id" },
            new GraphQlFieldMetadata { Name = "recipe_id" },
            new GraphQlFieldMetadata { Name = "integration_id" },
            new GraphQlFieldMetadata { Name = "tool_name" },
            new GraphQlFieldMetadata { Name = "mcp_server" },
            new GraphQlFieldMetadata { Name = "event_status" },
            new GraphQlFieldMetadata { Name = "error_message" },
            new GraphQlFieldMetadata { Name = "tool_start_timestamp" },
            new GraphQlFieldMetadata { Name = "tool_finish_timestamp" },
            new GraphQlFieldMetadata { Name = "execution_duration_ms" }
        };

        protected override string TypeName => "ToolEvent";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ToolEventQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public ToolEventQueryBuilder ExceptID() =>
            ExceptField("id");
        public ToolEventQueryBuilder WithAccountID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("account_id", alias, new GraphQlDirective?[] { include, skip });
        public ToolEventQueryBuilder ExceptAccountID() =>
            ExceptField("account_id");
        public ToolEventQueryBuilder WithUserID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("user_id", alias, new GraphQlDirective?[] { include, skip });
        public ToolEventQueryBuilder ExceptUserID() =>
            ExceptField("user_id");
        public ToolEventQueryBuilder WithTriggerUUID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("trigger_uuid", alias, new GraphQlDirective?[] { include, skip });
        public ToolEventQueryBuilder ExceptTriggerUUID() =>
            ExceptField("trigger_uuid");
        public ToolEventQueryBuilder WithAtomicActionID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("atomic_action_id", alias, new GraphQlDirective?[] { include, skip });
        public ToolEventQueryBuilder ExceptAtomicActionID() =>
            ExceptField("atomic_action_id");
        public ToolEventQueryBuilder WithRecipeID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("recipe_id", alias, new GraphQlDirective?[] { include, skip });
        public ToolEventQueryBuilder ExceptRecipeID() =>
            ExceptField("recipe_id");
        public ToolEventQueryBuilder WithIntegrationID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("integration_id", alias, new GraphQlDirective?[] { include, skip });
        public ToolEventQueryBuilder ExceptIntegrationID() =>
            ExceptField("integration_id");
        public ToolEventQueryBuilder WithToolName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("tool_name", alias, new GraphQlDirective?[] { include, skip });
        public ToolEventQueryBuilder ExceptToolName() =>
            ExceptField("tool_name");
        public ToolEventQueryBuilder WithMCPServer(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("mcp_server", alias, new GraphQlDirective?[] { include, skip });
        public ToolEventQueryBuilder ExceptMCPServer() =>
            ExceptField("mcp_server");
        public ToolEventQueryBuilder WithEventStatus(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("event_status", alias, new GraphQlDirective?[] { include, skip });
        public ToolEventQueryBuilder ExceptEventStatus() =>
            ExceptField("event_status");
        public ToolEventQueryBuilder WithErrorMessage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("error_message", alias, new GraphQlDirective?[] { include, skip });
        public ToolEventQueryBuilder ExceptErrorMessage() =>
            ExceptField("error_message");
        public ToolEventQueryBuilder WithToolStartTimestamp(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("tool_start_timestamp", alias, new GraphQlDirective?[] { include, skip });
        public ToolEventQueryBuilder ExceptToolStartTimestamp() =>
            ExceptField("tool_start_timestamp");
        public ToolEventQueryBuilder WithToolFinishTimestamp(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("tool_finish_timestamp", alias, new GraphQlDirective?[] { include, skip });
        public ToolEventQueryBuilder ExceptToolFinishTimestamp() =>
            ExceptField("tool_finish_timestamp");
        public ToolEventQueryBuilder WithExecutionDurationMS(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("execution_duration_ms", alias, new GraphQlDirective?[] { include, skip });
        public ToolEventQueryBuilder ExceptExecutionDurationMS() =>
            ExceptField("execution_duration_ms");
    }
}

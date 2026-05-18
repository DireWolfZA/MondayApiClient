using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AccountTriggersByEntityIDQueryBuilder : GraphQlQueryBuilder<AccountTriggersByEntityIDQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "automation_statistics" },
            new GraphQlFieldMetadata { Name = "workflow_statistics" }
        };

        protected override string TypeName => "AccountTriggersByEntityId";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AccountTriggersByEntityIDQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public AccountTriggersByEntityIDQueryBuilder ExceptID() =>
            ExceptField("id");
        public AccountTriggersByEntityIDQueryBuilder WithAutomationStatistics(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("automation_statistics", alias, new GraphQlDirective?[] { include, skip });
        public AccountTriggersByEntityIDQueryBuilder ExceptAutomationStatistics() =>
            ExceptField("automation_statistics");
        public AccountTriggersByEntityIDQueryBuilder WithWorkflowStatistics(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("workflow_statistics", alias, new GraphQlDirective?[] { include, skip });
        public AccountTriggersByEntityIDQueryBuilder ExceptWorkflowStatistics() =>
            ExceptField("workflow_statistics");
    }
}

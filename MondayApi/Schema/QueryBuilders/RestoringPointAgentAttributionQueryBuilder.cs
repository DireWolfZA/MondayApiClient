using System.Collections.Generic;

namespace MondayApi.Schema {
    public class RestoringPointAgentAttributionQueryBuilder : GraphQlQueryBuilder<RestoringPointAgentAttributionQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "agent_id" },
            new GraphQlFieldMetadata { Name = "entity_type" },
            new GraphQlFieldMetadata { Name = "agent_name" }
        };

        protected override string TypeName => "RestoringPointAgentAttribution";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public RestoringPointAgentAttributionQueryBuilder WithAgentID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("agent_id", alias, new GraphQlDirective?[] { include, skip });
        public RestoringPointAgentAttributionQueryBuilder ExceptAgentID() =>
            ExceptField("agent_id");
        public RestoringPointAgentAttributionQueryBuilder WithEntityType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("entity_type", alias, new GraphQlDirective?[] { include, skip });
        public RestoringPointAgentAttributionQueryBuilder ExceptEntityType() =>
            ExceptField("entity_type");
        public RestoringPointAgentAttributionQueryBuilder WithAgentName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("agent_name", alias, new GraphQlDirective?[] { include, skip });
        public RestoringPointAgentAttributionQueryBuilder ExceptAgentName() =>
            ExceptField("agent_name");
    }
}

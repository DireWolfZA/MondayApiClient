using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DocRestoringPointQueryBuilder : GraphQlQueryBuilder<DocRestoringPointQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "date" },
            new GraphQlFieldMetadata { Name = "user_ids", IsComplex = true },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "agent_attributions", IsComplex = true, QueryBuilderType = typeof(RestoringPointAgentAttributionQueryBuilder) }
        };

        protected override string TypeName => "DocRestoringPoint";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DocRestoringPointQueryBuilder WithDate(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("date", alias, new GraphQlDirective?[] { include, skip });
        public DocRestoringPointQueryBuilder ExceptDate() =>
            ExceptField("date");
        public DocRestoringPointQueryBuilder WithUserIDs(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("user_ids", alias, new GraphQlDirective?[] { include, skip });
        public DocRestoringPointQueryBuilder ExceptUserIds() =>
            ExceptField("user_ids");
        public DocRestoringPointQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public DocRestoringPointQueryBuilder ExceptType() =>
            ExceptField("type");
        public DocRestoringPointQueryBuilder WithAgentAttributions(RestoringPointAgentAttributionQueryBuilder restoringPointAgentAttributionQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("agent_attributions", alias, restoringPointAgentAttributionQueryBuilder, new GraphQlDirective?[] { include, skip });
        public DocRestoringPointQueryBuilder ExceptAgentAttributions() =>
            ExceptField("agent_attributions");
    }
}

using System.Collections.Generic;

namespace MondayApi.Schema {
    public class WorkspaceSettingsQueryBuilder : GraphQlQueryBuilder<WorkspaceSettingsQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new[]
            {
                new GraphQlFieldMetadata { Name = "icon", IsComplex = true, QueryBuilderType = typeof(WorkspaceIconQueryBuilder) }
            };

        protected override string TypeName { get { return "WorkspaceSettings"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public WorkspaceSettingsQueryBuilder WithIcon(WorkspaceIconQueryBuilder workspaceIconQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("icon", alias, workspaceIconQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public WorkspaceSettingsQueryBuilder ExceptIcon() {
            return ExceptField("icon");
        }
    }
}

using System.Collections.Generic;

namespace MondayApi.Schema {
    public class OverviewQueryBuilder : GraphQlQueryBuilder<OverviewQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "creator", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "folder_id" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "kind" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "state" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "workspace_id" }
        };

        protected override string TypeName => "Overview";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public OverviewQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective?[] { include, skip });
        public OverviewQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public OverviewQueryBuilder WithCreator(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("creator", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public OverviewQueryBuilder ExceptCreator() =>
            ExceptField("creator");
        public OverviewQueryBuilder WithFolderID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("folder_id", alias, new GraphQlDirective?[] { include, skip });
        public OverviewQueryBuilder ExceptFolderID() =>
            ExceptField("folder_id");
        public OverviewQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public OverviewQueryBuilder ExceptID() =>
            ExceptField("id");
        public OverviewQueryBuilder WithKind(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("kind", alias, new GraphQlDirective?[] { include, skip });
        public OverviewQueryBuilder ExceptKind() =>
            ExceptField("kind");
        public OverviewQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public OverviewQueryBuilder ExceptName() =>
            ExceptField("name");
        public OverviewQueryBuilder WithState(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("state", alias, new GraphQlDirective?[] { include, skip });
        public OverviewQueryBuilder ExceptState() =>
            ExceptField("state");
        public OverviewQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective?[] { include, skip });
        public OverviewQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public OverviewQueryBuilder WithWorkspaceID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("workspace_id", alias, new GraphQlDirective?[] { include, skip });
        public OverviewQueryBuilder ExceptWorkspaceID() =>
            ExceptField("workspace_id");
    }
}

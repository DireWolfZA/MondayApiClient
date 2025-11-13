using System.Collections.Generic;

namespace MondayApi.Schema {
    public class SprintSnapshotQueryBuilder : GraphQlQueryBuilder<SprintSnapshotQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "items", IsComplex = true, QueryBuilderType = typeof(SprintSnapshotItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "columns_metadata", IsComplex = true, QueryBuilderType = typeof(SprintSnapshotColumnMetadataQueryBuilder) },
            new GraphQlFieldMetadata { Name = "sprint_id" },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "updated_at" }
        };

        protected override string TypeName => "SprintSnapshot";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public SprintSnapshotQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public SprintSnapshotQueryBuilder ExceptID() =>
            ExceptField("id");
        public SprintSnapshotQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public SprintSnapshotQueryBuilder ExceptType() =>
            ExceptField("type");
        public SprintSnapshotQueryBuilder WithItems(SprintSnapshotItemQueryBuilder sprintSnapshotItemQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("items", alias, sprintSnapshotItemQueryBuilder, new GraphQlDirective?[] { include, skip });
        public SprintSnapshotQueryBuilder ExceptItems() =>
            ExceptField("items");
        public SprintSnapshotQueryBuilder WithColumnsMetadata(SprintSnapshotColumnMetadataQueryBuilder sprintSnapshotColumnMetadataQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("columns_metadata", alias, sprintSnapshotColumnMetadataQueryBuilder, new GraphQlDirective?[] { include, skip });
        public SprintSnapshotQueryBuilder ExceptColumnsMetadata() =>
            ExceptField("columns_metadata");
        public SprintSnapshotQueryBuilder WithSprintID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("sprint_id", alias, new GraphQlDirective?[] { include, skip });
        public SprintSnapshotQueryBuilder ExceptSprintID() =>
            ExceptField("sprint_id");
        public SprintSnapshotQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective?[] { include, skip });
        public SprintSnapshotQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public SprintSnapshotQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective?[] { include, skip });
        public SprintSnapshotQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
    }
}

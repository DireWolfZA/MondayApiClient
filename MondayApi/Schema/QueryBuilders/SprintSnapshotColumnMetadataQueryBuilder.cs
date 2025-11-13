using System.Collections.Generic;

namespace MondayApi.Schema {
    public class SprintSnapshotColumnMetadataQueryBuilder : GraphQlQueryBuilder<SprintSnapshotColumnMetadataQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "done_status_indexes", IsComplex = true }
        };

        protected override string TypeName => "SprintSnapshotColumnMetadata";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public SprintSnapshotColumnMetadataQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public SprintSnapshotColumnMetadataQueryBuilder ExceptID() =>
            ExceptField("id");
        public SprintSnapshotColumnMetadataQueryBuilder WithDoneStatusIndexes(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("done_status_indexes", alias, new GraphQlDirective?[] { include, skip });
        public SprintSnapshotColumnMetadataQueryBuilder ExceptDoneStatusIndexes() =>
            ExceptField("done_status_indexes");
    }
}

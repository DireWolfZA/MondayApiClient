using System.Collections.Generic;

namespace MondayApi.Schema {
    public class SprintSnapshotItemQueryBuilder : GraphQlQueryBuilder<SprintSnapshotItemQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "column_values", IsComplex = true, QueryBuilderType = typeof(SprintSnapshotItemColumnValueQueryBuilder) }
        };

        protected override string TypeName => "SprintSnapshotItem";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public SprintSnapshotItemQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public SprintSnapshotItemQueryBuilder ExceptID() =>
            ExceptField("id");
        public SprintSnapshotItemQueryBuilder WithColumnValues(SprintSnapshotItemColumnValueQueryBuilder sprintSnapshotItemColumnValueQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("column_values", alias, sprintSnapshotItemColumnValueQueryBuilder, new GraphQlDirective?[] { include, skip });
        public SprintSnapshotItemQueryBuilder ExceptColumnValues() =>
            ExceptField("column_values");
    }
}

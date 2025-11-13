using System.Collections.Generic;

namespace MondayApi.Schema {
    public class SprintSnapshotItemColumnValueQueryBuilder : GraphQlQueryBuilder<SprintSnapshotItemColumnValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "value" }
        };

        protected override string TypeName => "SprintSnapshotItemColumnValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public SprintSnapshotItemColumnValueQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public SprintSnapshotItemColumnValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public SprintSnapshotItemColumnValueQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public SprintSnapshotItemColumnValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public SprintSnapshotItemColumnValueQueryBuilder WithValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective?[] { include, skip });
        public SprintSnapshotItemColumnValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}

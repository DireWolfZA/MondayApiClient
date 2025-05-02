using System.Collections.Generic;

namespace MondayApi.Schema {
    [System.Obsolete("This column type is deprecated, see https://developer.monday.com/api-reference/reference/team")]
    public class TeamValueQueryBuilder : GraphQlQueryBuilder<TeamValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "team_id" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "value" }
        };

        protected override string TypeName => "TeamValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public TeamValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip });
        public TeamValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public TeamValueQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public TeamValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public TeamValueQueryBuilder WithTeamID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("team_id", alias, new GraphQlDirective?[] { include, skip });
        public TeamValueQueryBuilder ExceptTeamID() =>
            ExceptField("team_id");
        public TeamValueQueryBuilder WithText(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective?[] { include, skip });
        public TeamValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public TeamValueQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public TeamValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public TeamValueQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective?[] { include, skip });
        public TeamValueQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public TeamValueQueryBuilder WithValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective?[] { include, skip });
        public TeamValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}

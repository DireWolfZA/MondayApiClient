using System.Collections.Generic;

namespace MondayApi.Schema {
    public class LastUpdatedValueQueryBuilder : GraphQlQueryBuilder<LastUpdatedValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "updater", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "updater_id" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true }
        };

        protected override string TypeName => "LastUpdatedValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public LastUpdatedValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip });
        public LastUpdatedValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public LastUpdatedValueQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public LastUpdatedValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public LastUpdatedValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        public LastUpdatedValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public LastUpdatedValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public LastUpdatedValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public LastUpdatedValueQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        public LastUpdatedValueQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public LastUpdatedValueQueryBuilder WithUpdater(UserQueryBuilder userQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("updater", alias, userQueryBuilder, new GraphQlDirective[] { include, skip });
        public LastUpdatedValueQueryBuilder ExceptUpdater() =>
            ExceptField("updater");
        public LastUpdatedValueQueryBuilder WithUpdaterID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("updater_id", alias, new GraphQlDirective[] { include, skip });
        public LastUpdatedValueQueryBuilder ExceptUpdaterID() =>
            ExceptField("updater_id");
        public LastUpdatedValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        public LastUpdatedValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}

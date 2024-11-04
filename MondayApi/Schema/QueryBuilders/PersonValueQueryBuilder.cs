using System.Collections.Generic;

namespace MondayApi.Schema {
    [System.Obsolete("This column type is deprecated, see https://developer.monday.com/api-reference/reference/person")]
    public class PersonValueQueryBuilder : GraphQlQueryBuilder<PersonValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "person_id" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true }
        };

        protected override string TypeName => "PersonValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public PersonValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip });
        public PersonValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public PersonValueQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public PersonValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public PersonValueQueryBuilder WithPersonID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("person_id", alias, new GraphQlDirective[] { include, skip });
        public PersonValueQueryBuilder ExceptPersonID() =>
            ExceptField("person_id");
        public PersonValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        public PersonValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public PersonValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public PersonValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public PersonValueQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        public PersonValueQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public PersonValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        public PersonValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}

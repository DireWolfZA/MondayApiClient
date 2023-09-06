using System.Collections.Generic;

namespace MondayApi.Schema {
    public class PeopleValueQueryBuilder : GraphQlQueryBuilder<PeopleValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "persons_and_teams", IsComplex = true, QueryBuilderType = typeof(PeopleEntityQueryBuilder) },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true }
        };

        protected override string TypeName => "PeopleValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public PeopleValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip });
        public PeopleValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public PeopleValueQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public PeopleValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public PeopleValueQueryBuilder WithPersonsAndTeams(PeopleEntityQueryBuilder peopleEntityQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("persons_and_teams", alias, peopleEntityQueryBuilder, new GraphQlDirective[] { include, skip });
        public PeopleValueQueryBuilder ExceptPersonsAndTeams() =>
            ExceptField("persons_and_teams");
        public PeopleValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        public PeopleValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public PeopleValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public PeopleValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public PeopleValueQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        public PeopleValueQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public PeopleValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        public PeopleValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}

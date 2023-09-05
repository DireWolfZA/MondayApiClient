using System.Collections.Generic;

namespace MondayApi.Schema {
    public class CountryValueQueryBuilder : GraphQlQueryBuilder<CountryValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "country", IsComplex = true, QueryBuilderType = typeof(CountryQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true }
        };

        protected override string TypeName => "CountryValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public CountryValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip });
        public CountryValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public CountryValueQueryBuilder WithCountry(CountryQueryBuilder countryQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("country", alias, countryQueryBuilder, new GraphQlDirective[] { include, skip });
        public CountryValueQueryBuilder ExceptCountry() =>
            ExceptField("country");
        public CountryValueQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public CountryValueQueryBuilder ExceptId() =>
            ExceptField("id");
        public CountryValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        public CountryValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public CountryValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public CountryValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public CountryValueQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        public CountryValueQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public CountryValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        public CountryValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}

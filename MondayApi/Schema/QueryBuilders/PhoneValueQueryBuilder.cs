using System.Collections.Generic;

namespace MondayApi.Schema {
    public class PhoneValueQueryBuilder : GraphQlQueryBuilder<PhoneValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "country_short_name" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "phone" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "value" }
        };

        protected override string TypeName => "PhoneValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public PhoneValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip });
        public PhoneValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public PhoneValueQueryBuilder WithCountryShortName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("country_short_name", alias, new GraphQlDirective?[] { include, skip });
        public PhoneValueQueryBuilder ExceptCountryShortName() =>
            ExceptField("country_short_name");
        public PhoneValueQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public PhoneValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public PhoneValueQueryBuilder WithPhone(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("phone", alias, new GraphQlDirective?[] { include, skip });
        public PhoneValueQueryBuilder ExceptPhone() =>
            ExceptField("phone");
        public PhoneValueQueryBuilder WithText(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective?[] { include, skip });
        public PhoneValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public PhoneValueQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public PhoneValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public PhoneValueQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective?[] { include, skip });
        public PhoneValueQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public PhoneValueQueryBuilder WithValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective?[] { include, skip });
        public PhoneValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}

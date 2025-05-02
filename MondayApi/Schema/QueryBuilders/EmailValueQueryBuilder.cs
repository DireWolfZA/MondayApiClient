using System.Collections.Generic;

namespace MondayApi.Schema {
    public class EmailValueQueryBuilder : GraphQlQueryBuilder<EmailValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "email" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "label" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "value" }
        };

        protected override string TypeName => "EmailValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public EmailValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip });
        public EmailValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public EmailValueQueryBuilder WithEmail(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("email", alias, new GraphQlDirective?[] { include, skip });
        public EmailValueQueryBuilder ExceptEmail() =>
            ExceptField("email");
        public EmailValueQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public EmailValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public EmailValueQueryBuilder WithLabel(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("label", alias, new GraphQlDirective?[] { include, skip });
        public EmailValueQueryBuilder ExceptLabel() =>
            ExceptField("label");
        public EmailValueQueryBuilder WithText(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective?[] { include, skip });
        public EmailValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public EmailValueQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public EmailValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public EmailValueQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective?[] { include, skip });
        public EmailValueQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public EmailValueQueryBuilder WithValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective?[] { include, skip });
        public EmailValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}

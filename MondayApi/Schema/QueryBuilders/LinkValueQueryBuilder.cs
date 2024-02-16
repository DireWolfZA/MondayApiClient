using System.Collections.Generic;

namespace MondayApi.Schema {
    public class LinkValueQueryBuilder : GraphQlQueryBuilder<LinkValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "url" },
            new GraphQlFieldMetadata { Name = "url_text" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true }
        };

        protected override string TypeName => "LinkValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public LinkValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip });
        public LinkValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public LinkValueQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public LinkValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public LinkValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        public LinkValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public LinkValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public LinkValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public LinkValueQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        public LinkValueQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public LinkValueQueryBuilder WithURL(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("url", alias, new GraphQlDirective[] { include, skip });
        public LinkValueQueryBuilder ExceptURL() =>
            ExceptField("url");
        public LinkValueQueryBuilder WithUrlText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("url_text", alias, new GraphQlDirective[] { include, skip });
        public LinkValueQueryBuilder ExceptUrlText() =>
            ExceptField("url_text");
        public LinkValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        public LinkValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}

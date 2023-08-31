using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ColumnValueQueryBuilder : GraphQlQueryBuilder<ColumnValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new[]
            {
                new GraphQlFieldMetadata { Name = "additional_info", IsComplex = true },
                new GraphQlFieldMetadata { Name = "description" },
                new GraphQlFieldMetadata { Name = "id" },
                new GraphQlFieldMetadata { Name = "text" },
                new GraphQlFieldMetadata { Name = "title" },
                new GraphQlFieldMetadata { Name = "type" },
                new GraphQlFieldMetadata { Name = "value", IsComplex = true }
            };

        protected override string TypeName { get { return "ColumnValue"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public ColumnValueQueryBuilder WithAdditionalInfo(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("additional_info", alias, new GraphQlDirective[] { include, skip });
        }

        public ColumnValueQueryBuilder ExceptAdditionalInfo() {
            return ExceptField("additional_info");
        }

        public ColumnValueQueryBuilder WithDescription(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("description", alias, new GraphQlDirective[] { include, skip });
        }

        public ColumnValueQueryBuilder ExceptDescription() {
            return ExceptField("description");
        }

        public ColumnValueQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public ColumnValueQueryBuilder ExceptId() {
            return ExceptField("id");
        }

        public ColumnValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        }

        public ColumnValueQueryBuilder ExceptText() {
            return ExceptField("text");
        }

        public ColumnValueQueryBuilder WithTitle(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("title", alias, new GraphQlDirective[] { include, skip });
        }

        public ColumnValueQueryBuilder ExceptTitle() {
            return ExceptField("title");
        }

        public ColumnValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        }

        public ColumnValueQueryBuilder ExceptType() {
            return ExceptField("type");
        }

        public ColumnValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        }

        public ColumnValueQueryBuilder ExceptValue() {
            return ExceptField("value");
        }
    }
}

using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ColumnQueryBuilder : GraphQlQueryBuilder<ColumnQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new[]
            {
                new GraphQlFieldMetadata { Name = "archived" },
                new GraphQlFieldMetadata { Name = "description" },
                new GraphQlFieldMetadata { Name = "id" },
                new GraphQlFieldMetadata { Name = "settings_str" },
                new GraphQlFieldMetadata { Name = "title" },
                new GraphQlFieldMetadata { Name = "type" },
                new GraphQlFieldMetadata { Name = "width" }
            };

        protected override string TypeName { get { return "Column"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public ColumnQueryBuilder WithArchived(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("archived", alias, new GraphQlDirective[] { include, skip });
        }

        public ColumnQueryBuilder ExceptArchived() {
            return ExceptField("archived");
        }

        public ColumnQueryBuilder WithDescription(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("description", alias, new GraphQlDirective[] { include, skip });
        }

        public ColumnQueryBuilder ExceptDescription() {
            return ExceptField("description");
        }

        public ColumnQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public ColumnQueryBuilder ExceptId() {
            return ExceptField("id");
        }

        public ColumnQueryBuilder WithSettingsStr(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("settings_str", alias, new GraphQlDirective[] { include, skip });
        }

        public ColumnQueryBuilder ExceptSettingsStr() {
            return ExceptField("settings_str");
        }

        public ColumnQueryBuilder WithTitle(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("title", alias, new GraphQlDirective[] { include, skip });
        }

        public ColumnQueryBuilder ExceptTitle() {
            return ExceptField("title");
        }

        public ColumnQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        }

        public ColumnQueryBuilder ExceptType() {
            return ExceptField("type");
        }

        public ColumnQueryBuilder WithWidth(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("width", alias, new GraphQlDirective[] { include, skip });
        }

        public ColumnQueryBuilder ExceptWidth() {
            return ExceptField("width");
        }
    }
}

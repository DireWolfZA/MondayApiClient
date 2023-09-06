using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ColumnQueryBuilder : GraphQlQueryBuilder<ColumnQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "archived" },
            new GraphQlFieldMetadata { Name = "description" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "settings_str" },
            new GraphQlFieldMetadata { Name = "title" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "width" }
        };

        protected override string TypeName => "Column";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ColumnQueryBuilder WithArchived(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("archived", alias, new GraphQlDirective[] { include, skip });
        public ColumnQueryBuilder ExceptArchived() =>
            ExceptField("archived");
        public ColumnQueryBuilder WithDescription(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective[] { include, skip });
        public ColumnQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public ColumnQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public ColumnQueryBuilder ExceptID() =>
            ExceptField("id");
        public ColumnQueryBuilder WithSettingsStr(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("settings_str", alias, new GraphQlDirective[] { include, skip });
        public ColumnQueryBuilder ExceptSettingsStr() =>
            ExceptField("settings_str");
        public ColumnQueryBuilder WithTitle(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("title", alias, new GraphQlDirective[] { include, skip });
        public ColumnQueryBuilder ExceptTitle() =>
            ExceptField("title");
        public ColumnQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public ColumnQueryBuilder ExceptType() =>
            ExceptField("type");
        public ColumnQueryBuilder WithWidth(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("width", alias, new GraphQlDirective[] { include, skip });
        public ColumnQueryBuilder ExceptWidth() =>
            ExceptField("width");
    }
}

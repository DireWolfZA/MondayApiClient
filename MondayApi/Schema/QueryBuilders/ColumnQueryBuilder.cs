using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ColumnQueryBuilder : GraphQlQueryBuilder<ColumnQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "title" },
            new GraphQlFieldMetadata { Name = "description" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "width" },
            new GraphQlFieldMetadata { Name = "archived" },
            new GraphQlFieldMetadata { Name = "settings" },
            new GraphQlFieldMetadata { Name = "revision" },
            new GraphQlFieldMetadata { Name = "capabilities", IsComplex = true, QueryBuilderType = typeof(ColumnCapabilitiesQueryBuilder) }
        };

        protected override string TypeName => "Column";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ColumnQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public ColumnQueryBuilder ExceptID() =>
            ExceptField("id");
        public ColumnQueryBuilder WithTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("title", alias, new GraphQlDirective?[] { include, skip });
        public ColumnQueryBuilder ExceptTitle() =>
            ExceptField("title");
        public ColumnQueryBuilder WithDescription(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective?[] { include, skip });
        public ColumnQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public ColumnQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public ColumnQueryBuilder ExceptType() =>
            ExceptField("type");
        public ColumnQueryBuilder WithWidth(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("width", alias, new GraphQlDirective?[] { include, skip });
        public ColumnQueryBuilder ExceptWidth() =>
            ExceptField("width");
        public ColumnQueryBuilder WithArchived(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("archived", alias, new GraphQlDirective?[] { include, skip });
        public ColumnQueryBuilder ExceptArchived() =>
            ExceptField("archived");
        public ColumnQueryBuilder WithSettings(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("settings", alias, new GraphQlDirective?[] { include, skip });
        public ColumnQueryBuilder ExceptSettings() =>
            ExceptField("settings");
        public ColumnQueryBuilder WithRevision(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("revision", alias, new GraphQlDirective?[] { include, skip });
        public ColumnQueryBuilder ExceptRevision() =>
            ExceptField("revision");
        public ColumnQueryBuilder WithCapabilities(ColumnCapabilitiesQueryBuilder columnCapabilitiesQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("capabilities", alias, columnCapabilitiesQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ColumnQueryBuilder ExceptCapabilities() =>
            ExceptField("capabilities");
    }
}

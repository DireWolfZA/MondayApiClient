using System.Collections.Generic;

namespace MondayApi.Schema {
    public class SubtasksValueQueryBuilder : GraphQlQueryBuilder<SubtasksValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "display_value" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "subitems", IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "subitems_ids", IsComplex = true },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "value" }
        };

        protected override string TypeName => "SubtasksValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public SubtasksValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip });
        public SubtasksValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public SubtasksValueQueryBuilder WithDisplayValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("display_value", alias, new GraphQlDirective?[] { include, skip });
        public SubtasksValueQueryBuilder ExceptDisplayValue() =>
            ExceptField("display_value");
        public SubtasksValueQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public SubtasksValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public SubtasksValueQueryBuilder WithSubitems(ItemQueryBuilder itemQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("subitems", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip });
        public SubtasksValueQueryBuilder ExceptSubitems() =>
            ExceptField("subitems");
        public SubtasksValueQueryBuilder WithSubitemsIds(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("subitems_ids", alias, new GraphQlDirective?[] { include, skip });
        public SubtasksValueQueryBuilder ExceptSubitemsIds() =>
            ExceptField("subitems_ids");
        public SubtasksValueQueryBuilder WithText(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective?[] { include, skip });
        public SubtasksValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public SubtasksValueQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public SubtasksValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public SubtasksValueQueryBuilder WithValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective?[] { include, skip });
        public SubtasksValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}

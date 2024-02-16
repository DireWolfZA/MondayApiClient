using System.Collections.Generic;

namespace MondayApi.Schema {
    public class MirrorValueQueryBuilder : GraphQlQueryBuilder<MirrorValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "display_value" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "mirrored_items", IsComplex = true, QueryBuilderType = typeof(MirroredItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true }
        };

        protected override string TypeName => "MirrorValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public MirrorValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirrorValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public MirrorValueQueryBuilder WithDisplayValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("display_value", alias, new GraphQlDirective[] { include, skip });
        public MirrorValueQueryBuilder ExceptDisplayValue() =>
            ExceptField("display_value");
        public MirrorValueQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public MirrorValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public MirrorValueQueryBuilder WithMirroredItems(MirroredItemQueryBuilder mirroredItemQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("mirrored_items", alias, mirroredItemQueryBuilder, new GraphQlDirective[] { include, skip });
        public MirrorValueQueryBuilder ExceptMirroredItems() =>
            ExceptField("mirrored_items");
        public MirrorValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        public MirrorValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public MirrorValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public MirrorValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public MirrorValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        public MirrorValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}

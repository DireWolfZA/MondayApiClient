using System.Collections.Generic;

namespace MondayApi.Schema {
    public class TagsValueQueryBuilder : GraphQlQueryBuilder<TagsValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "tag_ids", IsComplex = true },
            new GraphQlFieldMetadata { Name = "tags", IsComplex = true, QueryBuilderType = typeof(TagQueryBuilder) },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "value" }
        };

        protected override string TypeName => "TagsValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public TagsValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip });
        public TagsValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public TagsValueQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public TagsValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public TagsValueQueryBuilder WithTagIDs(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("tag_ids", alias, new GraphQlDirective?[] { include, skip });
        public TagsValueQueryBuilder ExceptTagIDs() =>
            ExceptField("tag_ids");
        public TagsValueQueryBuilder WithTags(TagQueryBuilder tagQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("tags", alias, tagQueryBuilder, new GraphQlDirective?[] { include, skip });
        public TagsValueQueryBuilder ExceptTags() =>
            ExceptField("tags");
        public TagsValueQueryBuilder WithText(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective?[] { include, skip });
        public TagsValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public TagsValueQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public TagsValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public TagsValueQueryBuilder WithValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective?[] { include, skip });
        public TagsValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}

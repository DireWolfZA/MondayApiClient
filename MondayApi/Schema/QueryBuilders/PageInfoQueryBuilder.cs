using System.Collections.Generic;

namespace MondayApi.Schema {
    public class PageInfoQueryBuilder : GraphQlQueryBuilder<PageInfoQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "has_next_page" },
            new GraphQlFieldMetadata { Name = "cursor" }
        };

        protected override string TypeName => "PageInfo";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public PageInfoQueryBuilder WithHasNextPage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("has_next_page", alias, new GraphQlDirective?[] { include, skip });
        public PageInfoQueryBuilder ExceptHasNextPage() =>
            ExceptField("has_next_page");
        public PageInfoQueryBuilder WithCursor(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("cursor", alias, new GraphQlDirective?[] { include, skip });
        public PageInfoQueryBuilder ExceptCursor() =>
            ExceptField("cursor");
    }
}

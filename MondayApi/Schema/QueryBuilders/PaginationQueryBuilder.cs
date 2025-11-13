using System.Collections.Generic;

namespace MondayApi.Schema {
    public class PaginationQueryBuilder : GraphQlQueryBuilder<PaginationQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "page" },
            new GraphQlFieldMetadata { Name = "page_size" },
            new GraphQlFieldMetadata { Name = "has_more_pages" },
            new GraphQlFieldMetadata { Name = "next_page_number" }
        };

        protected override string TypeName => "Pagination";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public PaginationQueryBuilder WithPage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("page", alias, new GraphQlDirective?[] { include, skip });
        public PaginationQueryBuilder ExceptPage() =>
            ExceptField("page");
        public PaginationQueryBuilder WithPageSize(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("page_size", alias, new GraphQlDirective?[] { include, skip });
        public PaginationQueryBuilder ExceptPageSize() =>
            ExceptField("page_size");
        public PaginationQueryBuilder WithHasMorePages(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("has_more_pages", alias, new GraphQlDirective?[] { include, skip });
        public PaginationQueryBuilder ExceptHasMorePages() =>
            ExceptField("has_more_pages");
        public PaginationQueryBuilder WithNextPageNumber(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("next_page_number", alias, new GraphQlDirective?[] { include, skip });
        public PaginationQueryBuilder ExceptNextPageNumber() =>
            ExceptField("next_page_number");
    }
}

using System.Collections.Generic;

namespace MondayApi.Schema {
    public class SnippetSearchResultQueryBuilder : GraphQlQueryBuilder<SnippetSearchResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "title" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "parent_id" },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "distance" },
            new GraphQlFieldMetadata { Name = "url" }
        };

        protected override string TypeName => "SnippetSearchResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public SnippetSearchResultQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public SnippetSearchResultQueryBuilder ExceptID() =>
            ExceptField("id");
        public SnippetSearchResultQueryBuilder WithTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("title", alias, new GraphQlDirective?[] { include, skip });
        public SnippetSearchResultQueryBuilder ExceptTitle() =>
            ExceptField("title");
        public SnippetSearchResultQueryBuilder WithText(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective?[] { include, skip });
        public SnippetSearchResultQueryBuilder ExceptText() =>
            ExceptField("text");
        public SnippetSearchResultQueryBuilder WithParentID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("parent_id", alias, new GraphQlDirective?[] { include, skip });
        public SnippetSearchResultQueryBuilder ExceptParentID() =>
            ExceptField("parent_id");
        public SnippetSearchResultQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective?[] { include, skip });
        public SnippetSearchResultQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public SnippetSearchResultQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective?[] { include, skip });
        public SnippetSearchResultQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public SnippetSearchResultQueryBuilder WithDistance(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("distance", alias, new GraphQlDirective?[] { include, skip });
        public SnippetSearchResultQueryBuilder ExceptDistance() =>
            ExceptField("distance");
        public SnippetSearchResultQueryBuilder WithURL(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("url", alias, new GraphQlDirective?[] { include, skip });
        public SnippetSearchResultQueryBuilder ExceptURL() =>
            ExceptField("url");
    }
}

using System.Collections.Generic;

namespace MondayApi.Schema {
    public class NextPageRequestDataQueryBuilder : GraphQlQueryBuilder<NextPageRequestDataQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "page" },
            new GraphQlFieldMetadata { Name = "cursor" }
        };

        protected override string TypeName => "NextPageRequestData";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public NextPageRequestDataQueryBuilder WithPage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("page", alias, new GraphQlDirective?[] { include, skip });
        public NextPageRequestDataQueryBuilder ExceptPage() =>
            ExceptField("page");
        public NextPageRequestDataQueryBuilder WithCursor(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("cursor", alias, new GraphQlDirective?[] { include, skip });
        public NextPageRequestDataQueryBuilder ExceptCursor() =>
            ExceptField("cursor");
    }
}

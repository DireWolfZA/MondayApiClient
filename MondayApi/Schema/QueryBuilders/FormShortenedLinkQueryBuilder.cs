using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormShortenedLinkQueryBuilder : GraphQlQueryBuilder<FormShortenedLinkQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "enabled" },
            new GraphQlFieldMetadata { Name = "url" }
        };

        protected override string TypeName => "FormShortenedLink";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FormShortenedLinkQueryBuilder WithEnabled(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("enabled", alias, new GraphQlDirective?[] { include, skip });
        public FormShortenedLinkQueryBuilder ExceptEnabled() =>
            ExceptField("enabled");
        public FormShortenedLinkQueryBuilder WithURL(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("url", alias, new GraphQlDirective?[] { include, skip });
        public FormShortenedLinkQueryBuilder ExceptURL() =>
            ExceptField("url");
    }
}

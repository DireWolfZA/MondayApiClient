using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormAccessibilityQueryBuilder : GraphQlQueryBuilder<FormAccessibilityQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "language" },
            new GraphQlFieldMetadata { Name = "logoAltText" }
        };

        protected override string TypeName => "FormAccessibility";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FormAccessibilityQueryBuilder WithLanguage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("language", alias, new GraphQlDirective?[] { include, skip });
        public FormAccessibilityQueryBuilder ExceptLanguage() =>
            ExceptField("language");
        public FormAccessibilityQueryBuilder WithLogoAltText(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("logoAltText", alias, new GraphQlDirective?[] { include, skip });
        public FormAccessibilityQueryBuilder ExceptLogoAltText() =>
            ExceptField("logoAltText");
    }
}

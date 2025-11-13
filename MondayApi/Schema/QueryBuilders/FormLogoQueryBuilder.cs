using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormLogoQueryBuilder : GraphQlQueryBuilder<FormLogoQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "position" },
            new GraphQlFieldMetadata { Name = "url" },
            new GraphQlFieldMetadata { Name = "size" }
        };

        protected override string TypeName => "FormLogo";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FormLogoQueryBuilder WithPosition(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("position", alias, new GraphQlDirective?[] { include, skip });
        public FormLogoQueryBuilder ExceptPosition() =>
            ExceptField("position");
        public FormLogoQueryBuilder WithURL(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("url", alias, new GraphQlDirective?[] { include, skip });
        public FormLogoQueryBuilder ExceptURL() =>
            ExceptField("url");
        public FormLogoQueryBuilder WithSize(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("size", alias, new GraphQlDirective?[] { include, skip });
        public FormLogoQueryBuilder ExceptSize() =>
            ExceptField("size");
    }
}

using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormTextQueryBuilder : GraphQlQueryBuilder<FormTextQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "font" },
            new GraphQlFieldMetadata { Name = "color" },
            new GraphQlFieldMetadata { Name = "size" }
        };

        protected override string TypeName => "FormText";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FormTextQueryBuilder WithFont(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("font", alias, new GraphQlDirective?[] { include, skip });
        public FormTextQueryBuilder ExceptFont() =>
            ExceptField("font");
        public FormTextQueryBuilder WithColor(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("color", alias, new GraphQlDirective?[] { include, skip });
        public FormTextQueryBuilder ExceptColor() =>
            ExceptField("color");
        public FormTextQueryBuilder WithSize(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("size", alias, new GraphQlDirective?[] { include, skip });
        public FormTextQueryBuilder ExceptSize() =>
            ExceptField("size");
    }
}

using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormLayoutQueryBuilder : GraphQlQueryBuilder<FormLayoutQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "format" },
            new GraphQlFieldMetadata { Name = "alignment" },
            new GraphQlFieldMetadata { Name = "direction" }
        };

        protected override string TypeName => "FormLayout";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FormLayoutQueryBuilder WithFormat(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("format", alias, new GraphQlDirective?[] { include, skip });
        public FormLayoutQueryBuilder ExceptFormat() =>
            ExceptField("format");
        public FormLayoutQueryBuilder WithAlignment(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("alignment", alias, new GraphQlDirective?[] { include, skip });
        public FormLayoutQueryBuilder ExceptAlignment() =>
            ExceptField("alignment");
        public FormLayoutQueryBuilder WithDirection(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("direction", alias, new GraphQlDirective?[] { include, skip });
        public FormLayoutQueryBuilder ExceptDirection() =>
            ExceptField("direction");
    }
}

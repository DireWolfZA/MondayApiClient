using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormBackgroundQueryBuilder : GraphQlQueryBuilder<FormBackgroundQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "value" }
        };

        protected override string TypeName => "FormBackground";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FormBackgroundQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public FormBackgroundQueryBuilder ExceptType() =>
            ExceptField("type");
        public FormBackgroundQueryBuilder WithValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective?[] { include, skip });
        public FormBackgroundQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}

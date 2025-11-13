using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormSubmitButtonQueryBuilder : GraphQlQueryBuilder<FormSubmitButtonQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "text" }
        };

        protected override string TypeName => "FormSubmitButton";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FormSubmitButtonQueryBuilder WithText(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective?[] { include, skip });
        public FormSubmitButtonQueryBuilder ExceptText() =>
            ExceptField("text");
    }
}

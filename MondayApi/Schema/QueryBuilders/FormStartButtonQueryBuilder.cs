using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormStartButtonQueryBuilder : GraphQlQueryBuilder<FormStartButtonQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "text" }
        };

        protected override string TypeName => "FormStartButton";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FormStartButtonQueryBuilder WithText(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective?[] { include, skip });
        public FormStartButtonQueryBuilder ExceptText() =>
            ExceptField("text");
    }
}

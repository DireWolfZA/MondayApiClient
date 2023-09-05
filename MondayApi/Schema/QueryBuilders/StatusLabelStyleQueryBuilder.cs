using System.Collections.Generic;

namespace MondayApi.Schema {
    public class StatusLabelStyleQueryBuilder : GraphQlQueryBuilder<StatusLabelStyleQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "border" },
            new GraphQlFieldMetadata { Name = "color" }
        };

        protected override string TypeName => "StatusLabelStyle";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public StatusLabelStyleQueryBuilder WithBorder(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("border", alias, new GraphQlDirective[] { include, skip });
        public StatusLabelStyleQueryBuilder ExceptBorder() =>
            ExceptField("border");
        public StatusLabelStyleQueryBuilder WithColor(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("color", alias, new GraphQlDirective[] { include, skip });
        public StatusLabelStyleQueryBuilder ExceptColor() =>
            ExceptField("color");
    }
}

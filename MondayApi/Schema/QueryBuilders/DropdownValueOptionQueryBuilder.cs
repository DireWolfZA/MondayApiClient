using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DropdownValueOptionQueryBuilder : GraphQlQueryBuilder<DropdownValueOptionQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "label" }
        };

        protected override string TypeName => "DropdownValueOption";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DropdownValueOptionQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public DropdownValueOptionQueryBuilder ExceptId() =>
            ExceptField("id");
        public DropdownValueOptionQueryBuilder WithLabel(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("label", alias, new GraphQlDirective[] { include, skip });
        public DropdownValueOptionQueryBuilder ExceptLabel() =>
            ExceptField("label");
    }
}

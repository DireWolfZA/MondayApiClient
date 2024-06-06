using System.Collections.Generic;

namespace MondayApi.Schema {
    public class TemplateQueryBuilder : GraphQlQueryBuilder<TemplateQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "process_id" }
        };

        protected override string TypeName => "Template";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public TemplateQueryBuilder WithProcessID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("process_id", alias, new GraphQlDirective[] { include, skip });
        public TemplateQueryBuilder ExceptProcessID() =>
            ExceptField("process_id");
    }
}

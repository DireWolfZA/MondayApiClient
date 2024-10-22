using System.Collections.Generic;

namespace MondayApi.Schema {
    public class UpdatePinQueryBuilder : GraphQlQueryBuilder<UpdatePinQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "item_id" }
        };

        protected override string TypeName => "UpdatePin";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public UpdatePinQueryBuilder WithItemID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("item_id", alias, new GraphQlDirective[] { include, skip });
        public UpdatePinQueryBuilder ExceptItemID() =>
            ExceptField("item_id");
    }
}

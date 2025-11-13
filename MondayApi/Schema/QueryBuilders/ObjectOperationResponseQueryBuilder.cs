using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ObjectOperationResponseQueryBuilder : GraphQlQueryBuilder<ObjectOperationResponseQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "success" }
        };

        protected override string TypeName => "ObjectOperationResponse";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ObjectOperationResponseQueryBuilder WithSuccess(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("success", alias, new GraphQlDirective?[] { include, skip });
        public ObjectOperationResponseQueryBuilder ExceptSuccess() =>
            ExceptField("success");
    }
}

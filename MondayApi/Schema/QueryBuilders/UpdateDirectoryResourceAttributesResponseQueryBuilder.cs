using System.Collections.Generic;

namespace MondayApi.Schema {
    public class UpdateDirectoryResourceAttributesResponseQueryBuilder : GraphQlQueryBuilder<UpdateDirectoryResourceAttributesResponseQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "success" }
        };

        protected override string TypeName => "UpdateDirectoryResourceAttributesResponse";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public UpdateDirectoryResourceAttributesResponseQueryBuilder WithSuccess(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("success", alias, new GraphQlDirective?[] { include, skip });
        public UpdateDirectoryResourceAttributesResponseQueryBuilder ExceptSuccess() =>
            ExceptField("success");
    }
}

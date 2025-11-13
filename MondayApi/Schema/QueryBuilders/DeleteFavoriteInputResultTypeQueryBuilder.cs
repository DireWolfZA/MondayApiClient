using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DeleteFavoriteInputResultTypeQueryBuilder : GraphQlQueryBuilder<DeleteFavoriteInputResultTypeQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "success" }
        };

        protected override string TypeName => "DeleteFavoriteInputResultType";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DeleteFavoriteInputResultTypeQueryBuilder WithSuccess(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("success", alias, new GraphQlDirective?[] { include, skip });
        public DeleteFavoriteInputResultTypeQueryBuilder ExceptSuccess() =>
            ExceptField("success");
    }
}

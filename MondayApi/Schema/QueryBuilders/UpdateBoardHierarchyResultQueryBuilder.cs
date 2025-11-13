using System.Collections.Generic;

namespace MondayApi.Schema {
    public class UpdateBoardHierarchyResultQueryBuilder : GraphQlQueryBuilder<UpdateBoardHierarchyResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "board", IsComplex = true, QueryBuilderType = typeof(BoardQueryBuilder) },
            new GraphQlFieldMetadata { Name = "message" },
            new GraphQlFieldMetadata { Name = "success" }
        };

        protected override string TypeName => "UpdateBoardHierarchyResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public UpdateBoardHierarchyResultQueryBuilder WithBoard(BoardQueryBuilder boardQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("board", alias, boardQueryBuilder, new GraphQlDirective?[] { include, skip });
        public UpdateBoardHierarchyResultQueryBuilder ExceptBoard() =>
            ExceptField("board");
        public UpdateBoardHierarchyResultQueryBuilder WithMessage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("message", alias, new GraphQlDirective?[] { include, skip });
        public UpdateBoardHierarchyResultQueryBuilder ExceptMessage() =>
            ExceptField("message");
        public UpdateBoardHierarchyResultQueryBuilder WithSuccess(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("success", alias, new GraphQlDirective?[] { include, skip });
        public UpdateBoardHierarchyResultQueryBuilder ExceptSuccess() =>
            ExceptField("success");
    }
}

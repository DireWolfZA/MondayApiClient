using System.Collections.Generic;

namespace MondayApi.Schema {
    public class BoardDuplicationQueryBuilder : GraphQlQueryBuilder<BoardDuplicationQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "board", IsComplex = true, QueryBuilderType = typeof(BoardQueryBuilder) },
            new GraphQlFieldMetadata { Name = "is_async" }
        };

        protected override string TypeName => "BoardDuplication";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public BoardDuplicationQueryBuilder WithBoard(BoardQueryBuilder boardQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("board", alias, boardQueryBuilder, new GraphQlDirective[] { include, skip });
        public BoardDuplicationQueryBuilder ExceptBoard() =>
            ExceptField("board");
        public BoardDuplicationQueryBuilder WithIsAsync(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("is_async", alias, new GraphQlDirective[] { include, skip });
        public BoardDuplicationQueryBuilder ExceptIsAsync() =>
            ExceptField("is_async");
    }
}

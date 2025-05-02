using System.Collections.Generic;

namespace MondayApi.Schema {
    public class MirroredItemQueryBuilder : GraphQlQueryBuilder<MirroredItemQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "linked_board", IsComplex = true, QueryBuilderType = typeof(BoardQueryBuilder) },
            new GraphQlFieldMetadata { Name = "linked_board_id" },
            new GraphQlFieldMetadata { Name = "linked_item", IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "mirrored_value", IsComplex = true, QueryBuilderType = typeof(MirroredValueQueryBuilder) }
        };

        protected override string TypeName => "MirroredItem";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public MirroredItemQueryBuilder WithLinkedBoard(BoardQueryBuilder boardQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("linked_board", alias, boardQueryBuilder, new GraphQlDirective?[] { include, skip });
        public MirroredItemQueryBuilder ExceptLinkedBoard() =>
            ExceptField("linked_board");
        public MirroredItemQueryBuilder WithLinkedBoardID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("linked_board_id", alias, new GraphQlDirective?[] { include, skip });
        public MirroredItemQueryBuilder ExceptLinkedBoardID() =>
            ExceptField("linked_board_id");
        public MirroredItemQueryBuilder WithLinkedItem(ItemQueryBuilder itemQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("linked_item", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip });
        public MirroredItemQueryBuilder ExceptLinkedItem() =>
            ExceptField("linked_item");
        public MirroredItemQueryBuilder WithMirroredValue(MirroredValueQueryBuilder mirroredValueQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("mirrored_value", alias, mirroredValueQueryBuilder, new GraphQlDirective?[] { include, skip });
        public MirroredItemQueryBuilder ExceptMirroredValue() =>
            ExceptField("mirrored_value");
    }
}

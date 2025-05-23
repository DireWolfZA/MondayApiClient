using System.Collections.Generic;

namespace MondayApi.Schema {
    public class BlocksResultQueryBuilder : GraphQlQueryBuilder<BlocksResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "blocks", IsComplex = true, QueryBuilderType = typeof(BlockQueryBuilder) }
        };

        protected override string TypeName => "BlocksResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public BlocksResultQueryBuilder WithBlocks(BlockQueryBuilder blockQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("blocks", alias, blockQueryBuilder, new GraphQlDirective?[] { include, skip });
        public BlocksResultQueryBuilder ExceptBlocks() =>
            ExceptField("blocks");
    }
}

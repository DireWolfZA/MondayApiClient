using System.Collections.Generic;

namespace MondayApi.Schema {
    public class BlockEventsPageQueryBuilder : GraphQlQueryBuilder<BlockEventsPageQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "blockEvents", IsComplex = true, QueryBuilderType = typeof(BlockEventQueryBuilder) }
        };

        protected override string TypeName => "BlockEventsPage";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public BlockEventsPageQueryBuilder WithBlockEvents(BlockEventQueryBuilder blockEventQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("blockEvents", alias, blockEventQueryBuilder, new GraphQlDirective?[] { include, skip });
        public BlockEventsPageQueryBuilder ExceptBlockEvents() =>
            ExceptField("blockEvents");
    }
}

using System.Collections.Generic;

namespace MondayApi.Schema {
    public class BlockChangesQueryBuilder : GraphQlQueryBuilder<BlockChangesQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "added" },
            new GraphQlFieldMetadata { Name = "deleted" },
            new GraphQlFieldMetadata { Name = "changed" }
        };

        protected override string TypeName => "BlockChanges";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public BlockChangesQueryBuilder WithAdded(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("added", alias, new GraphQlDirective?[] { include, skip });
        public BlockChangesQueryBuilder ExceptAdded() =>
            ExceptField("added");
        public BlockChangesQueryBuilder WithDeleted(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("deleted", alias, new GraphQlDirective?[] { include, skip });
        public BlockChangesQueryBuilder ExceptDeleted() =>
            ExceptField("deleted");
        public BlockChangesQueryBuilder WithChanged(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("changed", alias, new GraphQlDirective?[] { include, skip });
        public BlockChangesQueryBuilder ExceptChanged() =>
            ExceptField("changed");
    }
}

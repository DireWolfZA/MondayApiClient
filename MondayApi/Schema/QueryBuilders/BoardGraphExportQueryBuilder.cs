using System.Collections.Generic;

namespace MondayApi.Schema {
    public class BoardGraphExportQueryBuilder : GraphQlQueryBuilder<BoardGraphExportQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "boardId" },
            new GraphQlFieldMetadata { Name = "graphData" },
            new GraphQlFieldMetadata { Name = "exportedAt" },
            new GraphQlFieldMetadata { Name = "nodeCount" },
            new GraphQlFieldMetadata { Name = "edgeCount" }
        };

        protected override string TypeName => "BoardGraphExport";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public BoardGraphExportQueryBuilder WithBoardID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("boardId", alias, new GraphQlDirective?[] { include, skip });
        public BoardGraphExportQueryBuilder ExceptBoardID() =>
            ExceptField("boardId");
        public BoardGraphExportQueryBuilder WithGraphData(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("graphData", alias, new GraphQlDirective?[] { include, skip });
        public BoardGraphExportQueryBuilder ExceptGraphData() =>
            ExceptField("graphData");
        public BoardGraphExportQueryBuilder WithExportedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("exportedAt", alias, new GraphQlDirective?[] { include, skip });
        public BoardGraphExportQueryBuilder ExceptExportedAt() =>
            ExceptField("exportedAt");
        public BoardGraphExportQueryBuilder WithNodeCount(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("nodeCount", alias, new GraphQlDirective?[] { include, skip });
        public BoardGraphExportQueryBuilder ExceptNodeCount() =>
            ExceptField("nodeCount");
        public BoardGraphExportQueryBuilder WithEdgeCount(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("edgeCount", alias, new GraphQlDirective?[] { include, skip });
        public BoardGraphExportQueryBuilder ExceptEdgeCount() =>
            ExceptField("edgeCount");
    }
}

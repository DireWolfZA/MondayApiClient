using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DehydratedFormResponseQueryBuilder : GraphQlQueryBuilder<DehydratedFormResponseQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "boardId" },
            new GraphQlFieldMetadata { Name = "token" }
        };

        protected override string TypeName => "DehydratedFormResponse";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DehydratedFormResponseQueryBuilder WithBoardID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("boardId", alias, new GraphQlDirective?[] { include, skip });
        public DehydratedFormResponseQueryBuilder ExceptBoardID() =>
            ExceptField("boardId");
        public DehydratedFormResponseQueryBuilder WithToken(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("token", alias, new GraphQlDirective?[] { include, skip });
        public DehydratedFormResponseQueryBuilder ExceptToken() =>
            ExceptField("token");
    }
}

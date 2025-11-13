using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ConvertBoardToProjectResultQueryBuilder : GraphQlQueryBuilder<ConvertBoardToProjectResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "success" },
            new GraphQlFieldMetadata { Name = "message" },
            new GraphQlFieldMetadata { Name = "projectId" },
            new GraphQlFieldMetadata { Name = "process_id" }
        };

        protected override string TypeName => "ConvertBoardToProjectResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ConvertBoardToProjectResultQueryBuilder WithSuccess(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("success", alias, new GraphQlDirective?[] { include, skip });
        public ConvertBoardToProjectResultQueryBuilder ExceptSuccess() =>
            ExceptField("success");
        public ConvertBoardToProjectResultQueryBuilder WithMessage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("message", alias, new GraphQlDirective?[] { include, skip });
        public ConvertBoardToProjectResultQueryBuilder ExceptMessage() =>
            ExceptField("message");
        public ConvertBoardToProjectResultQueryBuilder WithProjectID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("projectId", alias, new GraphQlDirective?[] { include, skip });
        public ConvertBoardToProjectResultQueryBuilder ExceptProjectID() =>
            ExceptField("projectId");
        public ConvertBoardToProjectResultQueryBuilder WithProcessID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("process_id", alias, new GraphQlDirective?[] { include, skip });
        public ConvertBoardToProjectResultQueryBuilder ExceptProcessID() =>
            ExceptField("process_id");
    }
}

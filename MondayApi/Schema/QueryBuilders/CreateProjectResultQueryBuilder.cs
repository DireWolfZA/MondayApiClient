using System.Collections.Generic;

namespace MondayApi.Schema {
    public class CreateProjectResultQueryBuilder : GraphQlQueryBuilder<CreateProjectResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "success" },
            new GraphQlFieldMetadata { Name = "message" },
            new GraphQlFieldMetadata { Name = "error" },
            new GraphQlFieldMetadata { Name = "process_id" }
        };

        protected override string TypeName => "CreateProjectResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public CreateProjectResultQueryBuilder WithSuccess(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("success", alias, new GraphQlDirective?[] { include, skip });
        public CreateProjectResultQueryBuilder ExceptSuccess() =>
            ExceptField("success");
        public CreateProjectResultQueryBuilder WithMessage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("message", alias, new GraphQlDirective?[] { include, skip });
        public CreateProjectResultQueryBuilder ExceptMessage() =>
            ExceptField("message");
        public CreateProjectResultQueryBuilder WithError(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("error", alias, new GraphQlDirective?[] { include, skip });
        public CreateProjectResultQueryBuilder ExceptError() =>
            ExceptField("error");
        public CreateProjectResultQueryBuilder WithProcessID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("process_id", alias, new GraphQlDirective?[] { include, skip });
        public CreateProjectResultQueryBuilder ExceptProcessID() =>
            ExceptField("process_id");
    }
}

using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AssignTeamOwnersErrorQueryBuilder : GraphQlQueryBuilder<AssignTeamOwnersErrorQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "message" },
            new GraphQlFieldMetadata { Name = "code" },
            new GraphQlFieldMetadata { Name = "user_id" }
        };

        protected override string TypeName => "AssignTeamOwnersError";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AssignTeamOwnersErrorQueryBuilder WithMessage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("message", alias, new GraphQlDirective?[] { include, skip });
        public AssignTeamOwnersErrorQueryBuilder ExceptMessage() =>
            ExceptField("message");
        public AssignTeamOwnersErrorQueryBuilder WithCode(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("code", alias, new GraphQlDirective?[] { include, skip });
        public AssignTeamOwnersErrorQueryBuilder ExceptCode() =>
            ExceptField("code");
        public AssignTeamOwnersErrorQueryBuilder WithUserID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("user_id", alias, new GraphQlDirective?[] { include, skip });
        public AssignTeamOwnersErrorQueryBuilder ExceptUserID() =>
            ExceptField("user_id");
    }
}

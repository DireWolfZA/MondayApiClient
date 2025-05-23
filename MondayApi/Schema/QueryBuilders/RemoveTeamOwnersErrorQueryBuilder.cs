using System.Collections.Generic;

namespace MondayApi.Schema {
    public class RemoveTeamOwnersErrorQueryBuilder : GraphQlQueryBuilder<RemoveTeamOwnersErrorQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "message" },
            new GraphQlFieldMetadata { Name = "code" },
            new GraphQlFieldMetadata { Name = "user_id" }
        };

        protected override string TypeName => "RemoveTeamOwnersError";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public RemoveTeamOwnersErrorQueryBuilder WithMessage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("message", alias, new GraphQlDirective?[] { include, skip });
        public RemoveTeamOwnersErrorQueryBuilder ExceptMessage() =>
            ExceptField("message");
        public RemoveTeamOwnersErrorQueryBuilder WithCode(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("code", alias, new GraphQlDirective?[] { include, skip });
        public RemoveTeamOwnersErrorQueryBuilder ExceptCode() =>
            ExceptField("code");
        public RemoveTeamOwnersErrorQueryBuilder WithUserID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("user_id", alias, new GraphQlDirective?[] { include, skip });
        public RemoveTeamOwnersErrorQueryBuilder ExceptUserID() =>
            ExceptField("user_id");
    }
}

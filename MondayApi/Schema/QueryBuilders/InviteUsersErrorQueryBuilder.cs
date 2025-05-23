using System.Collections.Generic;

namespace MondayApi.Schema {
    public class InviteUsersErrorQueryBuilder : GraphQlQueryBuilder<InviteUsersErrorQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "message" },
            new GraphQlFieldMetadata { Name = "code" },
            new GraphQlFieldMetadata { Name = "email" }
        };

        protected override string TypeName => "InviteUsersError";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public InviteUsersErrorQueryBuilder WithMessage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("message", alias, new GraphQlDirective?[] { include, skip });
        public InviteUsersErrorQueryBuilder ExceptMessage() =>
            ExceptField("message");
        public InviteUsersErrorQueryBuilder WithCode(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("code", alias, new GraphQlDirective?[] { include, skip });
        public InviteUsersErrorQueryBuilder ExceptCode() =>
            ExceptField("code");
        public InviteUsersErrorQueryBuilder WithEmail(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("email", alias, new GraphQlDirective?[] { include, skip });
        public InviteUsersErrorQueryBuilder ExceptEmail() =>
            ExceptField("email");
    }
}

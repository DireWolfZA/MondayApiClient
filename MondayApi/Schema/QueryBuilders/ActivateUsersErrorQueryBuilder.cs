using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ActivateUsersErrorQueryBuilder : GraphQlQueryBuilder<ActivateUsersErrorQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "message" },
            new GraphQlFieldMetadata { Name = "code" },
            new GraphQlFieldMetadata { Name = "user_id" }
        };

        protected override string TypeName => "ActivateUsersError";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ActivateUsersErrorQueryBuilder WithMessage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("message", alias, new GraphQlDirective?[] { include, skip });
        public ActivateUsersErrorQueryBuilder ExceptMessage() =>
            ExceptField("message");
        public ActivateUsersErrorQueryBuilder WithCode(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("code", alias, new GraphQlDirective?[] { include, skip });
        public ActivateUsersErrorQueryBuilder ExceptCode() =>
            ExceptField("code");
        public ActivateUsersErrorQueryBuilder WithUserID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("user_id", alias, new GraphQlDirective?[] { include, skip });
        public ActivateUsersErrorQueryBuilder ExceptUserID() =>
            ExceptField("user_id");
    }
}

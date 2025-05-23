using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DeactivateUsersErrorQueryBuilder : GraphQlQueryBuilder<DeactivateUsersErrorQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "message" },
            new GraphQlFieldMetadata { Name = "code" },
            new GraphQlFieldMetadata { Name = "user_id" }
        };

        protected override string TypeName => "DeactivateUsersError";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DeactivateUsersErrorQueryBuilder WithMessage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("message", alias, new GraphQlDirective?[] { include, skip });
        public DeactivateUsersErrorQueryBuilder ExceptMessage() =>
            ExceptField("message");
        public DeactivateUsersErrorQueryBuilder WithCode(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("code", alias, new GraphQlDirective?[] { include, skip });
        public DeactivateUsersErrorQueryBuilder ExceptCode() =>
            ExceptField("code");
        public DeactivateUsersErrorQueryBuilder WithUserID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("user_id", alias, new GraphQlDirective?[] { include, skip });
        public DeactivateUsersErrorQueryBuilder ExceptUserID() =>
            ExceptField("user_id");
    }
}

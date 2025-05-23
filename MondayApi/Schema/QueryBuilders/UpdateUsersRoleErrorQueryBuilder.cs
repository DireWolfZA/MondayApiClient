using System.Collections.Generic;

namespace MondayApi.Schema {
    public class UpdateUsersRoleErrorQueryBuilder : GraphQlQueryBuilder<UpdateUsersRoleErrorQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "message" },
            new GraphQlFieldMetadata { Name = "code" },
            new GraphQlFieldMetadata { Name = "user_id" }
        };

        protected override string TypeName => "UpdateUsersRoleError";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public UpdateUsersRoleErrorQueryBuilder WithMessage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("message", alias, new GraphQlDirective?[] { include, skip });
        public UpdateUsersRoleErrorQueryBuilder ExceptMessage() =>
            ExceptField("message");
        public UpdateUsersRoleErrorQueryBuilder WithCode(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("code", alias, new GraphQlDirective?[] { include, skip });
        public UpdateUsersRoleErrorQueryBuilder ExceptCode() =>
            ExceptField("code");
        public UpdateUsersRoleErrorQueryBuilder WithUserID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("user_id", alias, new GraphQlDirective?[] { include, skip });
        public UpdateUsersRoleErrorQueryBuilder ExceptUserID() =>
            ExceptField("user_id");
    }
}

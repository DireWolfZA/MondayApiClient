using System.Collections.Generic;

namespace MondayApi.Schema {
    public class UpdateUserAttributesErrorQueryBuilder : GraphQlQueryBuilder<UpdateUserAttributesErrorQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "message" },
            new GraphQlFieldMetadata { Name = "code" },
            new GraphQlFieldMetadata { Name = "user_id" }
        };

        protected override string TypeName => "UpdateUserAttributesError";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public UpdateUserAttributesErrorQueryBuilder WithMessage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("message", alias, new GraphQlDirective?[] { include, skip });
        public UpdateUserAttributesErrorQueryBuilder ExceptMessage() =>
            ExceptField("message");
        public UpdateUserAttributesErrorQueryBuilder WithCode(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("code", alias, new GraphQlDirective?[] { include, skip });
        public UpdateUserAttributesErrorQueryBuilder ExceptCode() =>
            ExceptField("code");
        public UpdateUserAttributesErrorQueryBuilder WithUserID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("user_id", alias, new GraphQlDirective?[] { include, skip });
        public UpdateUserAttributesErrorQueryBuilder ExceptUserID() =>
            ExceptField("user_id");
    }
}

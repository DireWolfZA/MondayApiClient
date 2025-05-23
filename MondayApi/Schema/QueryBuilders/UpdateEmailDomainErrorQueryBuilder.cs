using System.Collections.Generic;

namespace MondayApi.Schema {
    public class UpdateEmailDomainErrorQueryBuilder : GraphQlQueryBuilder<UpdateEmailDomainErrorQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "message" },
            new GraphQlFieldMetadata { Name = "code" },
            new GraphQlFieldMetadata { Name = "user_id" }
        };

        protected override string TypeName => "UpdateEmailDomainError";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public UpdateEmailDomainErrorQueryBuilder WithMessage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("message", alias, new GraphQlDirective?[] { include, skip });
        public UpdateEmailDomainErrorQueryBuilder ExceptMessage() =>
            ExceptField("message");
        public UpdateEmailDomainErrorQueryBuilder WithCode(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("code", alias, new GraphQlDirective?[] { include, skip });
        public UpdateEmailDomainErrorQueryBuilder ExceptCode() =>
            ExceptField("code");
        public UpdateEmailDomainErrorQueryBuilder WithUserID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("user_id", alias, new GraphQlDirective?[] { include, skip });
        public UpdateEmailDomainErrorQueryBuilder ExceptUserID() =>
            ExceptField("user_id");
    }
}

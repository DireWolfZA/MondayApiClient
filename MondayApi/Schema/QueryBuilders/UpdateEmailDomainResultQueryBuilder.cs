using System.Collections.Generic;

namespace MondayApi.Schema {
    public class UpdateEmailDomainResultQueryBuilder : GraphQlQueryBuilder<UpdateEmailDomainResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "updated_users", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "errors", IsComplex = true, QueryBuilderType = typeof(UpdateEmailDomainErrorQueryBuilder) }
        };

        protected override string TypeName => "UpdateEmailDomainResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public UpdateEmailDomainResultQueryBuilder WithUpdatedUsers(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("updated_users", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public UpdateEmailDomainResultQueryBuilder ExceptUpdatedUsers() =>
            ExceptField("updated_users");
        public UpdateEmailDomainResultQueryBuilder WithErrors(UpdateEmailDomainErrorQueryBuilder updateEmailDomainErrorQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("errors", alias, updateEmailDomainErrorQueryBuilder, new GraphQlDirective?[] { include, skip });
        public UpdateEmailDomainResultQueryBuilder ExceptErrors() =>
            ExceptField("errors");
    }
}

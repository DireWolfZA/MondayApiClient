using System.Collections.Generic;

namespace MondayApi.Schema {
    public class UpdateUserAttributesResultQueryBuilder : GraphQlQueryBuilder<UpdateUserAttributesResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "updated_users", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "errors", IsComplex = true, QueryBuilderType = typeof(UpdateUserAttributesErrorQueryBuilder) }
        };

        protected override string TypeName => "UpdateUserAttributesResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public UpdateUserAttributesResultQueryBuilder WithUpdatedUsers(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("updated_users", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public UpdateUserAttributesResultQueryBuilder ExceptUpdatedUsers() =>
            ExceptField("updated_users");
        public UpdateUserAttributesResultQueryBuilder WithErrors(UpdateUserAttributesErrorQueryBuilder updateUserAttributesErrorQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("errors", alias, updateUserAttributesErrorQueryBuilder, new GraphQlDirective?[] { include, skip });
        public UpdateUserAttributesResultQueryBuilder ExceptErrors() =>
            ExceptField("errors");
    }
}

using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormRequireLoginQueryBuilder : GraphQlQueryBuilder<FormRequireLoginQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "enabled" },
            new GraphQlFieldMetadata { Name = "redirectToLogin" }
        };

        protected override string TypeName => "FormRequireLogin";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FormRequireLoginQueryBuilder WithEnabled(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("enabled", alias, new GraphQlDirective?[] { include, skip });
        public FormRequireLoginQueryBuilder ExceptEnabled() =>
            ExceptField("enabled");
        public FormRequireLoginQueryBuilder WithRedirectToLogin(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("redirectToLogin", alias, new GraphQlDirective?[] { include, skip });
        public FormRequireLoginQueryBuilder ExceptRedirectToLogin() =>
            ExceptField("redirectToLogin");
    }
}

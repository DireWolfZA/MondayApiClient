using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AppInstallAccountQueryBuilder : GraphQlQueryBuilder<AppInstallAccountQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" }
        };

        protected override string TypeName => "AppInstallAccount";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AppInstallAccountQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public AppInstallAccountQueryBuilder ExceptID() =>
            ExceptField("id");
    }
}

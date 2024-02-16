using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AppInstallUserQueryBuilder : GraphQlQueryBuilder<AppInstallUserQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" }
        };

        protected override string TypeName => "AppInstallUser";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AppInstallUserQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public AppInstallUserQueryBuilder ExceptID() =>
            ExceptField("id");
    }
}

using System.Collections.Generic;

namespace MondayApi.Schema {
    public class WorkspaceIconQueryBuilder : GraphQlQueryBuilder<WorkspaceIconQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "color" },
            new GraphQlFieldMetadata { Name = "image" }
        };

        protected override string TypeName => "WorkspaceIcon";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public WorkspaceIconQueryBuilder WithColor(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("color", alias, new GraphQlDirective[] { include, skip });
        public WorkspaceIconQueryBuilder ExceptColor() =>
            ExceptField("color");
        public WorkspaceIconQueryBuilder WithImage(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("image", alias, new GraphQlDirective[] { include, skip });
        public WorkspaceIconQueryBuilder ExceptImage() =>
            ExceptField("image");
    }
}

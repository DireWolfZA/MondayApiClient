using System.Collections.Generic;

namespace MondayApi.Schema {
    public class WorkspaceIconQueryBuilder : GraphQlQueryBuilder<WorkspaceIconQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "color" },
            new GraphQlFieldMetadata { Name = "image" }
        };

        protected override string TypeName { get { return "WorkspaceIcon"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public WorkspaceIconQueryBuilder WithColor(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("color", alias, new GraphQlDirective[] { include, skip });
        }

        public WorkspaceIconQueryBuilder ExceptColor() {
            return ExceptField("color");
        }

        public WorkspaceIconQueryBuilder WithImage(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("image", alias, new GraphQlDirective[] { include, skip });
        }

        public WorkspaceIconQueryBuilder ExceptImage() {
            return ExceptField("image");
        }
    }
}

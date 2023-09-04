using System.Collections.Generic;

namespace MondayApi.Schema {
    public class GroupQueryBuilder : GraphQlQueryBuilder<GroupQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "archived" },
            new GraphQlFieldMetadata { Name = "color" },
            new GraphQlFieldMetadata { Name = "deleted" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "position" },
            new GraphQlFieldMetadata { Name = "title" }
        };

        protected override string TypeName => "Group";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public GroupQueryBuilder WithArchived(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("archived", alias, new GraphQlDirective[] { include, skip });
        public GroupQueryBuilder ExceptArchived() =>
            ExceptField("archived");
        public GroupQueryBuilder WithColor(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("color", alias, new GraphQlDirective[] { include, skip });
        public GroupQueryBuilder ExceptColor() =>
            ExceptField("color");
        public GroupQueryBuilder WithDeleted(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("deleted", alias, new GraphQlDirective[] { include, skip });
        public GroupQueryBuilder ExceptDeleted() =>
            ExceptField("deleted");
        public GroupQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public GroupQueryBuilder ExceptId() =>
            ExceptField("id");
        public GroupQueryBuilder WithPosition(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("position", alias, new GraphQlDirective[] { include, skip });
        public GroupQueryBuilder ExceptPosition() =>
            ExceptField("position");
        public GroupQueryBuilder WithTitle(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("title", alias, new GraphQlDirective[] { include, skip });
        public GroupQueryBuilder ExceptTitle() =>
            ExceptField("title");
    }
}

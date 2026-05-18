using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ActionItemQueryBuilder : GraphQlQueryBuilder<ActionItemQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "content" },
            new GraphQlFieldMetadata { Name = "is_completed" },
            new GraphQlFieldMetadata { Name = "owner" },
            new GraphQlFieldMetadata { Name = "due_date" }
        };

        protected override string TypeName => "ActionItem";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ActionItemQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public ActionItemQueryBuilder ExceptID() =>
            ExceptField("id");
        public ActionItemQueryBuilder WithContent(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("content", alias, new GraphQlDirective?[] { include, skip });
        public ActionItemQueryBuilder ExceptContent() =>
            ExceptField("content");
        public ActionItemQueryBuilder WithIsCompleted(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("is_completed", alias, new GraphQlDirective?[] { include, skip });
        public ActionItemQueryBuilder ExceptIsCompleted() =>
            ExceptField("is_completed");
        public ActionItemQueryBuilder WithOwner(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("owner", alias, new GraphQlDirective?[] { include, skip });
        public ActionItemQueryBuilder ExceptOwner() =>
            ExceptField("owner");
        public ActionItemQueryBuilder WithDueDate(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("due_date", alias, new GraphQlDirective?[] { include, skip });
        public ActionItemQueryBuilder ExceptDueDate() =>
            ExceptField("due_date");
    }
}

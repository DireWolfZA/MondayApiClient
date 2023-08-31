using System.Collections.Generic;

namespace MondayApi.Schema {
    public class NotificationQueryBuilder : GraphQlQueryBuilder<NotificationQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "text" }
        };

        protected override string TypeName { get { return "Notification"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public NotificationQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public NotificationQueryBuilder ExceptId() {
            return ExceptField("id");
        }

        public NotificationQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        }

        public NotificationQueryBuilder ExceptText() {
            return ExceptField("text");
        }
    }
}

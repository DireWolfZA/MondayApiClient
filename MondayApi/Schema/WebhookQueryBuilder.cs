using System.Collections.Generic;

namespace MondayApi.Schema {
    public class WebhookQueryBuilder : GraphQlQueryBuilder<WebhookQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new[]
            {
                new GraphQlFieldMetadata { Name = "board_id" },
                new GraphQlFieldMetadata { Name = "config" },
                new GraphQlFieldMetadata { Name = "event" },
                new GraphQlFieldMetadata { Name = "id" }
            };

        protected override string TypeName { get { return "Webhook"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public WebhookQueryBuilder WithBoardId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("board_id", alias, new GraphQlDirective[] { include, skip });
        }

        public WebhookQueryBuilder ExceptBoardId() {
            return ExceptField("board_id");
        }

        public WebhookQueryBuilder WithConfig(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("config", alias, new GraphQlDirective[] { include, skip });
        }

        public WebhookQueryBuilder ExceptConfig() {
            return ExceptField("config");
        }

        public WebhookQueryBuilder WithEvent(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("event", alias, new GraphQlDirective[] { include, skip });
        }

        public WebhookQueryBuilder ExceptEvent() {
            return ExceptField("event");
        }

        public WebhookQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public WebhookQueryBuilder ExceptId() {
            return ExceptField("id");
        }
    }
}

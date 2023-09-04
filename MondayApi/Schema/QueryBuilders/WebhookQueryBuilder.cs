using System.Collections.Generic;

namespace MondayApi.Schema {
    public class WebhookQueryBuilder : GraphQlQueryBuilder<WebhookQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "board_id" },
            new GraphQlFieldMetadata { Name = "config" },
            new GraphQlFieldMetadata { Name = "event" },
            new GraphQlFieldMetadata { Name = "id" }
        };

        protected override string TypeName => "Webhook";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public WebhookQueryBuilder WithBoardId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("board_id", alias, new GraphQlDirective[] { include, skip });
        public WebhookQueryBuilder ExceptBoardId() =>
            ExceptField("board_id");
        public WebhookQueryBuilder WithConfig(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("config", alias, new GraphQlDirective[] { include, skip });
        public WebhookQueryBuilder ExceptConfig() =>
            ExceptField("config");
        public WebhookQueryBuilder WithEvent(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("event", alias, new GraphQlDirective[] { include, skip });
        public WebhookQueryBuilder ExceptEvent() =>
            ExceptField("event");
        public WebhookQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public WebhookQueryBuilder ExceptId() =>
            ExceptField("id");
    }
}

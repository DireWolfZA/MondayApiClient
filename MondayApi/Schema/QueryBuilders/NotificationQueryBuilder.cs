using System.Collections.Generic;

namespace MondayApi.Schema {
    public class NotificationQueryBuilder : GraphQlQueryBuilder<NotificationQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "text" }
        };

        protected override string TypeName => "Notification";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public NotificationQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public NotificationQueryBuilder ExceptID() =>
            ExceptField("id");
        public NotificationQueryBuilder WithText(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective?[] { include, skip });
        public NotificationQueryBuilder ExceptText() =>
            ExceptField("text");
    }
}

using System.Collections.Generic;

namespace MondayApi.Schema {
    public class NotificationSettingChannelQueryBuilder : GraphQlQueryBuilder<NotificationSettingChannelQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "enabled" },
            new GraphQlFieldMetadata { Name = "editable_status" }
        };

        protected override string TypeName => "NotificationSettingChannel";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public NotificationSettingChannelQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public NotificationSettingChannelQueryBuilder ExceptName() =>
            ExceptField("name");
        public NotificationSettingChannelQueryBuilder WithEnabled(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("enabled", alias, new GraphQlDirective?[] { include, skip });
        public NotificationSettingChannelQueryBuilder ExceptEnabled() =>
            ExceptField("enabled");
        public NotificationSettingChannelQueryBuilder WithEditableStatus(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("editable_status", alias, new GraphQlDirective?[] { include, skip });
        public NotificationSettingChannelQueryBuilder ExceptEditableStatus() =>
            ExceptField("editable_status");
    }
}

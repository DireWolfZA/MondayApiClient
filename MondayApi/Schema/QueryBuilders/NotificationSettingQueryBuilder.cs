using System.Collections.Generic;

namespace MondayApi.Schema {
    public class NotificationSettingQueryBuilder : GraphQlQueryBuilder<NotificationSettingQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "kind" },
            new GraphQlFieldMetadata { Name = "description" },
            new GraphQlFieldMetadata { Name = "is_for_admins_only" },
            new GraphQlFieldMetadata { Name = "is_for_non_guests_only" },
            new GraphQlFieldMetadata { Name = "channels", IsComplex = true, QueryBuilderType = typeof(NotificationSettingChannelQueryBuilder) }
        };

        protected override string TypeName => "NotificationSetting";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public NotificationSettingQueryBuilder WithKind(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("kind", alias, new GraphQlDirective?[] { include, skip });
        public NotificationSettingQueryBuilder ExceptKind() =>
            ExceptField("kind");
        public NotificationSettingQueryBuilder WithDescription(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective?[] { include, skip });
        public NotificationSettingQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public NotificationSettingQueryBuilder WithIsForAdminsOnly(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("is_for_admins_only", alias, new GraphQlDirective?[] { include, skip });
        public NotificationSettingQueryBuilder ExceptIsForAdminsOnly() =>
            ExceptField("is_for_admins_only");
        public NotificationSettingQueryBuilder WithIsForNonGuestsOnly(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("is_for_non_guests_only", alias, new GraphQlDirective?[] { include, skip });
        public NotificationSettingQueryBuilder ExceptIsForNonGuestsOnly() =>
            ExceptField("is_for_non_guests_only");
        public NotificationSettingQueryBuilder WithChannels(NotificationSettingChannelQueryBuilder notificationSettingChannelQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("channels", alias, notificationSettingChannelQueryBuilder, new GraphQlDirective?[] { include, skip });
        public NotificationSettingQueryBuilder ExceptChannels() =>
            ExceptField("channels");
    }
}

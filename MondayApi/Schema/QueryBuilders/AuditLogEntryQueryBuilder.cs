using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AuditLogEntryQueryBuilder : GraphQlQueryBuilder<AuditLogEntryQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "timestamp" },
            new GraphQlFieldMetadata { Name = "account_id" },
            new GraphQlFieldMetadata { Name = "user", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "event" },
            new GraphQlFieldMetadata { Name = "slug" },
            new GraphQlFieldMetadata { Name = "ip_address" },
            new GraphQlFieldMetadata { Name = "user_agent" },
            new GraphQlFieldMetadata { Name = "client_name" },
            new GraphQlFieldMetadata { Name = "client_version" },
            new GraphQlFieldMetadata { Name = "os_name" },
            new GraphQlFieldMetadata { Name = "os_version" },
            new GraphQlFieldMetadata { Name = "device_name" },
            new GraphQlFieldMetadata { Name = "device_type" },
            new GraphQlFieldMetadata { Name = "activity_metadata" }
        };

        protected override string TypeName => "AuditLogEntry";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AuditLogEntryQueryBuilder WithTimestamp(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("timestamp", alias, new GraphQlDirective?[] { include, skip });
        public AuditLogEntryQueryBuilder ExceptTimestamp() =>
            ExceptField("timestamp");
        public AuditLogEntryQueryBuilder WithAccountID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("account_id", alias, new GraphQlDirective?[] { include, skip });
        public AuditLogEntryQueryBuilder ExceptAccountID() =>
            ExceptField("account_id");
        public AuditLogEntryQueryBuilder WithUser(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("user", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public AuditLogEntryQueryBuilder ExceptUser() =>
            ExceptField("user");
        public AuditLogEntryQueryBuilder WithEvent(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("event", alias, new GraphQlDirective?[] { include, skip });
        public AuditLogEntryQueryBuilder ExceptEvent() =>
            ExceptField("event");
        public AuditLogEntryQueryBuilder WithSlug(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("slug", alias, new GraphQlDirective?[] { include, skip });
        public AuditLogEntryQueryBuilder ExceptSlug() =>
            ExceptField("slug");
        public AuditLogEntryQueryBuilder WithIPAddress(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("ip_address", alias, new GraphQlDirective?[] { include, skip });
        public AuditLogEntryQueryBuilder ExceptIPAddress() =>
            ExceptField("ip_address");
        public AuditLogEntryQueryBuilder WithUserAgent(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("user_agent", alias, new GraphQlDirective?[] { include, skip });
        public AuditLogEntryQueryBuilder ExceptUserAgent() =>
            ExceptField("user_agent");
        public AuditLogEntryQueryBuilder WithClientName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("client_name", alias, new GraphQlDirective?[] { include, skip });
        public AuditLogEntryQueryBuilder ExceptClientName() =>
            ExceptField("client_name");
        public AuditLogEntryQueryBuilder WithClientVersion(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("client_version", alias, new GraphQlDirective?[] { include, skip });
        public AuditLogEntryQueryBuilder ExceptClientVersion() =>
            ExceptField("client_version");
        public AuditLogEntryQueryBuilder WithOSName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("os_name", alias, new GraphQlDirective?[] { include, skip });
        public AuditLogEntryQueryBuilder ExceptOSName() =>
            ExceptField("os_name");
        public AuditLogEntryQueryBuilder WithOSVersion(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("os_version", alias, new GraphQlDirective?[] { include, skip });
        public AuditLogEntryQueryBuilder ExceptOSVersion() =>
            ExceptField("os_version");
        public AuditLogEntryQueryBuilder WithDeviceName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("device_name", alias, new GraphQlDirective?[] { include, skip });
        public AuditLogEntryQueryBuilder ExceptDeviceName() =>
            ExceptField("device_name");
        public AuditLogEntryQueryBuilder WithDeviceType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("device_type", alias, new GraphQlDirective?[] { include, skip });
        public AuditLogEntryQueryBuilder ExceptDeviceType() =>
            ExceptField("device_type");
        public AuditLogEntryQueryBuilder WithActivityMetadata(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("activity_metadata", alias, new GraphQlDirective?[] { include, skip });
        public AuditLogEntryQueryBuilder ExceptActivityMetadata() =>
            ExceptField("activity_metadata");
    }
}

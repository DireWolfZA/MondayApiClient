using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AuditLogPageQueryBuilder : GraphQlQueryBuilder<AuditLogPageQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "logs", IsComplex = true, QueryBuilderType = typeof(AuditLogEntryQueryBuilder) },
            new GraphQlFieldMetadata { Name = "pagination", IsComplex = true, QueryBuilderType = typeof(PaginationQueryBuilder) }
        };

        protected override string TypeName => "AuditLogPage";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AuditLogPageQueryBuilder WithLogs(AuditLogEntryQueryBuilder auditLogEntryQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("logs", alias, auditLogEntryQueryBuilder, new GraphQlDirective?[] { include, skip });
        public AuditLogPageQueryBuilder ExceptLogs() =>
            ExceptField("logs");
        public AuditLogPageQueryBuilder WithPagination(PaginationQueryBuilder paginationQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("pagination", alias, paginationQueryBuilder, new GraphQlDirective?[] { include, skip });
        public AuditLogPageQueryBuilder ExceptPagination() =>
            ExceptField("pagination");
    }
}

using System.Collections.Generic;

namespace MondayApi.Schema {
    public class QueryQueryBuilder : GraphQlQueryBuilder<QueryQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "audit_logs", IsComplex = true, QueryBuilderType = typeof(AuditLogPageQueryBuilder) },
            new GraphQlFieldMetadata { Name = "audit_event_catalogue", IsComplex = true, QueryBuilderType = typeof(AuditEventCatalogueEntryQueryBuilder) },
            new GraphQlFieldMetadata { Name = "connections", IsComplex = true, QueryBuilderType = typeof(ConnectionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "user_connections", IsComplex = true, QueryBuilderType = typeof(ConnectionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "account_connections", IsComplex = true, QueryBuilderType = typeof(ConnectionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "connection", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ConnectionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "connection_board_ids", RequiresParameters = true, IsComplex = true },
            new GraphQlFieldMetadata { Name = "trigger_events", IsComplex = true, QueryBuilderType = typeof(TriggerEventsPageQueryBuilder) },
            new GraphQlFieldMetadata { Name = "trigger_event", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(TriggerEventQueryBuilder) },
            new GraphQlFieldMetadata { Name = "block_events", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(BlockEventsPageQueryBuilder) },
            new GraphQlFieldMetadata { Name = "get_view_schema_by_type", RequiresParameters = true },
            new GraphQlFieldMetadata { Name = "updates", IsComplex = true, QueryBuilderType = typeof(UpdateQueryBuilder) },
            new GraphQlFieldMetadata { Name = "replies", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ReplyQueryBuilder) },
            new GraphQlFieldMetadata { Name = "custom_activity", IsComplex = true, QueryBuilderType = typeof(CustomActivityQueryBuilder) },
            new GraphQlFieldMetadata { Name = "timeline_item", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(TimelineItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "timeline", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(TimelineResponseQueryBuilder) },
            new GraphQlFieldMetadata { Name = "managed_column", IsComplex = true, QueryBuilderType = typeof(ManagedColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "get_column_type_schema", RequiresParameters = true },
            new GraphQlFieldMetadata { Name = "validations", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ValidationsQueryBuilder) },
            new GraphQlFieldMetadata { Name = "export_graph", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(BoardGraphExportQueryBuilder) },
            new GraphQlFieldMetadata { Name = "export_markdown_from_doc", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ExportMarkdownResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "favorites", IsComplex = true, QueryBuilderType = typeof(GraphQLHierarchyObjectItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "marketplace_app_discounts", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(MarketplaceAppDiscountQueryBuilder) },
            new GraphQlFieldMetadata { Name = "app_subscriptions", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AppSubscriptionsQueryBuilder) },
            new GraphQlFieldMetadata { Name = "marketplace_vector_search", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(MarketplaceSearchResultsQueryBuilder) },
            new GraphQlFieldMetadata { Name = "marketplace_fulltext_search", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(MarketplaceSearchResultsQueryBuilder) },
            new GraphQlFieldMetadata { Name = "marketplace_hybrid_search", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(MarketplaceSearchResultsQueryBuilder) },
            new GraphQlFieldMetadata { Name = "marketplace_ai_search", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(MarketplaceAISearchResultsQueryBuilder) },
            new GraphQlFieldMetadata { Name = "app", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AppTypeQueryBuilder) },
            new GraphQlFieldMetadata { Name = "account", IsComplex = true, QueryBuilderType = typeof(AccountQueryBuilder) },
            new GraphQlFieldMetadata { Name = "app_installs", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AppInstallQueryBuilder) },
            new GraphQlFieldMetadata { Name = "app_subscription", IsComplex = true, QueryBuilderType = typeof(AppSubscriptionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "app_subscription_operations", IsComplex = true, QueryBuilderType = typeof(AppSubscriptionOperationsCounterQueryBuilder) },
            new GraphQlFieldMetadata { Name = "apps_monetization_info", IsComplex = true, QueryBuilderType = typeof(AppsMonetizationInfoQueryBuilder) },
            new GraphQlFieldMetadata { Name = "apps_monetization_status", IsComplex = true, QueryBuilderType = typeof(AppMonetizationStatusQueryBuilder) },
            new GraphQlFieldMetadata { Name = "assets", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AssetQueryBuilder) },
            new GraphQlFieldMetadata { Name = "boards", IsComplex = true, QueryBuilderType = typeof(BoardQueryBuilder) },
            new GraphQlFieldMetadata { Name = "complexity", IsComplex = true, QueryBuilderType = typeof(ComplexityQueryBuilder) },
            new GraphQlFieldMetadata { Name = "docs", IsComplex = true, QueryBuilderType = typeof(DocumentQueryBuilder) },
            new GraphQlFieldMetadata { Name = "folders", IsComplex = true, QueryBuilderType = typeof(FolderQueryBuilder) },
            new GraphQlFieldMetadata { Name = "items", IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "items_page_by_column_values", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemsResponseQueryBuilder) },
            new GraphQlFieldMetadata { Name = "me", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "next_items_page", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemsResponseQueryBuilder) },
            new GraphQlFieldMetadata { Name = "tags", IsComplex = true, QueryBuilderType = typeof(TagQueryBuilder) },
            new GraphQlFieldMetadata { Name = "teams", IsComplex = true, QueryBuilderType = typeof(TeamQueryBuilder) },
            new GraphQlFieldMetadata { Name = "users", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "webhooks", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(WebhookQueryBuilder) },
            new GraphQlFieldMetadata { Name = "workspaces", IsComplex = true, QueryBuilderType = typeof(WorkspaceQueryBuilder) },
            new GraphQlFieldMetadata { Name = "board_candidates", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(BoardQueryBuilder) },
            new GraphQlFieldMetadata { Name = "notifications", IsComplex = true, QueryBuilderType = typeof(NotificationV2QueryBuilder) },
            new GraphQlFieldMetadata { Name = "notifications_settings", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(NotificationSettingQueryBuilder) },
            new GraphQlFieldMetadata { Name = "mute_board_settings", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(BoardMuteSettingsQueryBuilder) },
            new GraphQlFieldMetadata { Name = "object_types_unique_keys", IsComplex = true, QueryBuilderType = typeof(ObjectTypeUniqueKeyQueryBuilder) },
            new GraphQlFieldMetadata { Name = "objects", IsComplex = true, QueryBuilderType = typeof(ObjectQueryBuilder) },
            new GraphQlFieldMetadata { Name = "version", IsComplex = true, QueryBuilderType = typeof(VersionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "versions", IsComplex = true, QueryBuilderType = typeof(VersionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "platform_api", IsComplex = true, QueryBuilderType = typeof(PlatformAPIQueryBuilder) },
            new GraphQlFieldMetadata { Name = "aggregate", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AggregateQueryResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "sprints", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(SprintQueryBuilder) },
            new GraphQlFieldMetadata { Name = "account_roles", IsComplex = true, QueryBuilderType = typeof(AccountRoleQueryBuilder) },
            new GraphQlFieldMetadata { Name = "all_widgets_schema", IsComplex = true, QueryBuilderType = typeof(WidgetSchemaInfoQueryBuilder) },
            new GraphQlFieldMetadata { Name = "form", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ResponseFormQueryBuilder) }
        };

        public QueryQueryBuilder(string? operationName = null) : base("query", operationName) { }
        protected override string TypeName => "Query";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public QueryQueryBuilder WithParameter<T>(GraphQlQueryParameter<T> parameter) =>
            WithParameterInternal(parameter);
        public QueryQueryBuilder WithAuditLogs(AuditLogPageQueryBuilder auditLogPageQueryBuilder, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<int?>? page = null, QueryBuilderParameter<string?>? userID = null, QueryBuilderParameter<IEnumerable<string>>? events = null, QueryBuilderParameter<string?>? ipAddress = null, QueryBuilderParameter<object?>? startTime = null, QueryBuilderParameter<object?>? endTime = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            if (userID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "user_id", ArgumentValue = userID });
            if (events != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "events", ArgumentValue = events });
            if (ipAddress != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ip_address", ArgumentValue = ipAddress });
            if (startTime != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "start_time", ArgumentValue = startTime });
            if (endTime != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "end_time", ArgumentValue = endTime });
            return WithObjectField("audit_logs", alias, auditLogPageQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptAuditLogs() =>
            ExceptField("audit_logs");
        public QueryQueryBuilder WithAuditEventCatalogue(AuditEventCatalogueEntryQueryBuilder auditEventCatalogueEntryQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("audit_event_catalogue", alias, auditEventCatalogueEntryQueryBuilder, new GraphQlDirective?[] { include, skip });
        public QueryQueryBuilder ExceptAuditEventCatalogue() =>
            ExceptField("audit_event_catalogue");
        public QueryQueryBuilder WithConnections(ConnectionQueryBuilder connectionQueryBuilder, QueryBuilderParameter<bool?>? withAutomations = null, QueryBuilderParameter<string?>? connectionState = null, QueryBuilderParameter<bool?>? withStateValidation = null, QueryBuilderParameter<int?>? page = null, QueryBuilderParameter<int?>? pageSize = null, QueryBuilderParameter<string?>? order = null, QueryBuilderParameter<bool?>? withPartialScopes = null, QueryBuilderParameter<PaginationInput?>? pagination = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (withAutomations != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "withAutomations", ArgumentValue = withAutomations });
            if (connectionState != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "connectionState", ArgumentValue = connectionState });
            if (withStateValidation != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "withStateValidation", ArgumentValue = withStateValidation });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            if (pageSize != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "pageSize", ArgumentValue = pageSize });
            if (order != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "order", ArgumentValue = order });
            if (withPartialScopes != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "withPartialScopes", ArgumentValue = withPartialScopes });
            if (pagination != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "pagination", ArgumentValue = pagination });
            return WithObjectField("connections", alias, connectionQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptConnections() =>
            ExceptField("connections");
        public QueryQueryBuilder WithUserConnections(ConnectionQueryBuilder connectionQueryBuilder, QueryBuilderParameter<bool?>? withAutomations = null, QueryBuilderParameter<bool?>? withStateValidation = null, QueryBuilderParameter<int?>? page = null, QueryBuilderParameter<int?>? pageSize = null, QueryBuilderParameter<string?>? order = null, QueryBuilderParameter<PaginationInput?>? pagination = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (withAutomations != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "withAutomations", ArgumentValue = withAutomations });
            if (withStateValidation != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "withStateValidation", ArgumentValue = withStateValidation });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            if (pageSize != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "pageSize", ArgumentValue = pageSize });
            if (order != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "order", ArgumentValue = order });
            if (pagination != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "pagination", ArgumentValue = pagination });
            return WithObjectField("user_connections", alias, connectionQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptUserConnections() =>
            ExceptField("user_connections");
        public QueryQueryBuilder WithAccountConnections(ConnectionQueryBuilder connectionQueryBuilder, QueryBuilderParameter<bool?>? withAutomations = null, QueryBuilderParameter<bool?>? withStateValidation = null, QueryBuilderParameter<int?>? page = null, QueryBuilderParameter<int?>? pageSize = null, QueryBuilderParameter<string?>? order = null, QueryBuilderParameter<PaginationInput?>? pagination = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (withAutomations != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "withAutomations", ArgumentValue = withAutomations });
            if (withStateValidation != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "withStateValidation", ArgumentValue = withStateValidation });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            if (pageSize != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "pageSize", ArgumentValue = pageSize });
            if (order != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "order", ArgumentValue = order });
            if (pagination != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "pagination", ArgumentValue = pagination });
            return WithObjectField("account_connections", alias, connectionQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptAccountConnections() =>
            ExceptField("account_connections");
        public QueryQueryBuilder WithConnection(ConnectionQueryBuilder connectionQueryBuilder, QueryBuilderParameter<int> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("connection", alias, connectionQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptConnection() =>
            ExceptField("connection");
        public QueryQueryBuilder WithConnectionBoardIds(QueryBuilderParameter<int> connectionID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "connectionId", ArgumentValue = connectionID }
            };
            return WithScalarField("connection_board_ids", alias, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptConnectionBoardIds() =>
            ExceptField("connection_board_ids");
        public QueryQueryBuilder WithTriggerEvents(TriggerEventsPageQueryBuilder triggerEventsPageQueryBuilder, QueryBuilderParameter<int?>? nextPageOffset = null, QueryBuilderParameter<TriggerEventsFiltersInput?>? filters = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (nextPageOffset != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "nextPageOffset", ArgumentValue = nextPageOffset });
            if (filters != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "filters", ArgumentValue = filters });
            return WithObjectField("trigger_events", alias, triggerEventsPageQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptTriggerEvents() =>
            ExceptField("trigger_events");
        public QueryQueryBuilder WithTriggerEvent(TriggerEventQueryBuilder triggerEventQueryBuilder, QueryBuilderParameter<string> triggerUUID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "triggerUuid", ArgumentValue = triggerUUID }
            };
            return WithObjectField("trigger_event", alias, triggerEventQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptTriggerEvent() =>
            ExceptField("trigger_event");
        public QueryQueryBuilder WithBlockEvents(BlockEventsPageQueryBuilder blockEventsPageQueryBuilder, QueryBuilderParameter<string> triggerUUID, QueryBuilderParameter<int?>? nextPageOffset = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "triggerUuid", ArgumentValue = triggerUUID }
            };
            if (nextPageOffset != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "nextPageOffset", ArgumentValue = nextPageOffset });
            return WithObjectField("block_events", alias, blockEventsPageQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptBlockEvents() =>
            ExceptField("block_events");
        public QueryQueryBuilder WithGetViewSchemaByType(QueryBuilderParameter<ViewKind> type, QueryBuilderParameter<ViewMutationKind> mutationType, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "type", ArgumentValue = type },
                new QueryBuilderArgumentInfo { ArgumentName = "mutationType", ArgumentValue = mutationType }
            };
            return WithScalarField("get_view_schema_by_type", alias, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptGetViewSchemaByType() =>
            ExceptField("get_view_schema_by_type");
        public QueryQueryBuilder WithUpdates(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<int?>? page = null, QueryBuilderParameter<IEnumerable<string>>? ids = null, QueryBuilderParameter<string?>? fromDate = null, QueryBuilderParameter<string?>? toDate = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            if (fromDate != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "from_date", ArgumentValue = fromDate });
            if (toDate != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "to_date", ArgumentValue = toDate });
            return WithObjectField("updates", alias, updateQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptUpdates() =>
            ExceptField("updates");
        public QueryQueryBuilder WithReplies(ReplyQueryBuilder replyQueryBuilder, QueryBuilderParameter<IEnumerable<string>> boardIDs, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<int?>? page = null, QueryBuilderParameter<string?>? createdAtFrom = null, QueryBuilderParameter<string?>? createdAtTo = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_ids", ArgumentValue = boardIDs });
            if (createdAtFrom != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "created_at_from", ArgumentValue = createdAtFrom });
            if (createdAtTo != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "created_at_to", ArgumentValue = createdAtTo });
            return WithObjectField("replies", alias, replyQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptReplies() =>
            ExceptField("replies");
        public QueryQueryBuilder WithCustomActivity(CustomActivityQueryBuilder customActivityQueryBuilder, QueryBuilderParameter<IEnumerable<string>>? ids = null, QueryBuilderParameter<string?>? name = null, QueryBuilderParameter<CustomActivityIcon?>? iconID = null, QueryBuilderParameter<CustomActivityColor?>? color = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            if (name != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name });
            if (iconID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "icon_id", ArgumentValue = iconID });
            if (color != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "color", ArgumentValue = color });
            return WithObjectField("custom_activity", alias, customActivityQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptCustomActivity() =>
            ExceptField("custom_activity");
        public QueryQueryBuilder WithTimelineItem(TimelineItemQueryBuilder timelineItemQueryBuilder, QueryBuilderParameter<string> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("timeline_item", alias, timelineItemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptTimelineItem() =>
            ExceptField("timeline_item");
        public QueryQueryBuilder WithTimeline(TimelineResponseQueryBuilder timelineResponseQueryBuilder, QueryBuilderParameter<string> id, QueryBuilderParameter<bool?>? skipConnectedItems = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            if (skipConnectedItems != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "skipConnectedItems", ArgumentValue = skipConnectedItems });
            return WithObjectField("timeline", alias, timelineResponseQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptTimeline() =>
            ExceptField("timeline");
        public QueryQueryBuilder WithManagedColumn(ManagedColumnQueryBuilder managedColumnQueryBuilder, QueryBuilderParameter<IEnumerable<string>>? id = null, QueryBuilderParameter<IEnumerable<ManagedColumnState>>? state = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (id != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id });
            if (state != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "state", ArgumentValue = state });
            return WithObjectField("managed_column", alias, managedColumnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptManagedColumn() =>
            ExceptField("managed_column");
        public QueryQueryBuilder WithGetColumnTypeSchema(QueryBuilderParameter<ColumnType> type, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "type", ArgumentValue = type }
            };
            return WithScalarField("get_column_type_schema", alias, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptGetColumnTypeSchema() =>
            ExceptField("get_column_type_schema");
        public QueryQueryBuilder WithValidations(ValidationsQueryBuilder validationsQueryBuilder, QueryBuilderParameter<string> id, QueryBuilderParameter<ValidationsEntityType?>? type = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            if (type != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "type", ArgumentValue = type });
            return WithObjectField("validations", alias, validationsQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptValidations() =>
            ExceptField("validations");
        public QueryQueryBuilder WithExportGraph(BoardGraphExportQueryBuilder boardGraphExportQueryBuilder, QueryBuilderParameter<string> boardID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "boardId", ArgumentValue = boardID }
            };
            return WithObjectField("export_graph", alias, boardGraphExportQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptExportGraph() =>
            ExceptField("export_graph");
        public QueryQueryBuilder WithExportMarkdownFromDoc(ExportMarkdownResultQueryBuilder exportMarkdownResultQueryBuilder, QueryBuilderParameter<string> docID, QueryBuilderParameter<IEnumerable<string>>? blockIDs = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "docId", ArgumentValue = docID }
            };
            if (blockIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "blockIds", ArgumentValue = blockIDs });
            return WithObjectField("export_markdown_from_doc", alias, exportMarkdownResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptExportMarkdownFromDoc() =>
            ExceptField("export_markdown_from_doc");
        public QueryQueryBuilder WithFavorites(GraphQLHierarchyObjectItemQueryBuilder graphqlHierarchyObjectItemQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("favorites", alias, graphqlHierarchyObjectItemQueryBuilder, new GraphQlDirective?[] { include, skip });
        public QueryQueryBuilder ExceptFavorites() =>
            ExceptField("favorites");
        public QueryQueryBuilder WithMarketplaceAppDiscounts(MarketplaceAppDiscountQueryBuilder marketplaceAppDiscountQueryBuilder, QueryBuilderParameter<string> appID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "app_id", ArgumentValue = appID }
            };
            return WithObjectField("marketplace_app_discounts", alias, marketplaceAppDiscountQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptMarketplaceAppDiscounts() =>
            ExceptField("marketplace_app_discounts");
        public QueryQueryBuilder WithAppSubscriptions(AppSubscriptionsQueryBuilder appSubscriptionsQueryBuilder, QueryBuilderParameter<string> appID, QueryBuilderParameter<SubscriptionStatus?>? status = null, QueryBuilderParameter<int?>? accountID = null, QueryBuilderParameter<string?>? cursor = null, QueryBuilderParameter<int?>? limit = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "app_id", ArgumentValue = appID }
            };
            if (status != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "status", ArgumentValue = status });
            if (accountID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "account_id", ArgumentValue = accountID });
            if (cursor != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "cursor", ArgumentValue = cursor });
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            return WithObjectField("app_subscriptions", alias, appSubscriptionsQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptAppSubscriptions() =>
            ExceptField("app_subscriptions");
        public QueryQueryBuilder WithMarketplaceVectorSearch(MarketplaceSearchResultsQueryBuilder marketplaceSearchResultsQueryBuilder, QueryBuilderParameter<MarketplaceSearchInput> input, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "input", ArgumentValue = input }
            };
            return WithObjectField("marketplace_vector_search", alias, marketplaceSearchResultsQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptMarketplaceVectorSearch() =>
            ExceptField("marketplace_vector_search");
        public QueryQueryBuilder WithMarketplaceFulltextSearch(MarketplaceSearchResultsQueryBuilder marketplaceSearchResultsQueryBuilder, QueryBuilderParameter<MarketplaceSearchInput> input, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "input", ArgumentValue = input }
            };
            return WithObjectField("marketplace_fulltext_search", alias, marketplaceSearchResultsQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptMarketplaceFulltextSearch() =>
            ExceptField("marketplace_fulltext_search");
        public QueryQueryBuilder WithMarketplaceHybridSearch(MarketplaceSearchResultsQueryBuilder marketplaceSearchResultsQueryBuilder, QueryBuilderParameter<MarketplaceSearchInput> input, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "input", ArgumentValue = input }
            };
            return WithObjectField("marketplace_hybrid_search", alias, marketplaceSearchResultsQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptMarketplaceHybridSearch() =>
            ExceptField("marketplace_hybrid_search");
        public QueryQueryBuilder WithMarketplaceAiSearch(MarketplaceAISearchResultsQueryBuilder marketplaceAiSearchResultsQueryBuilder, QueryBuilderParameter<MarketplaceAiSearchInput> input, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "input", ArgumentValue = input }
            };
            return WithObjectField("marketplace_ai_search", alias, marketplaceAiSearchResultsQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptMarketplaceAiSearch() =>
            ExceptField("marketplace_ai_search");
        public QueryQueryBuilder WithApp(AppTypeQueryBuilder appTypeQueryBuilder, QueryBuilderParameter<string> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("app", alias, appTypeQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptApp() =>
            ExceptField("app");
        public QueryQueryBuilder WithAccount(AccountQueryBuilder accountQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("account", alias, accountQueryBuilder, new GraphQlDirective?[] { include, skip });
        public QueryQueryBuilder ExceptAccount() =>
            ExceptField("account");
        public QueryQueryBuilder WithAppInstalls(AppInstallQueryBuilder appInstallQueryBuilder, QueryBuilderParameter<string> appID, QueryBuilderParameter<string?>? accountID = null, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<int?>? page = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (accountID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "account_id", ArgumentValue = accountID });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "app_id", ArgumentValue = appID });
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            return WithObjectField("app_installs", alias, appInstallQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptAppInstalls() =>
            ExceptField("app_installs");
        public QueryQueryBuilder WithAppSubscription(AppSubscriptionQueryBuilder appSubscriptionQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("app_subscription", alias, appSubscriptionQueryBuilder, new GraphQlDirective?[] { include, skip });
        public QueryQueryBuilder ExceptAppSubscription() =>
            ExceptField("app_subscription");
        public QueryQueryBuilder WithAppSubscriptionOperations(AppSubscriptionOperationsCounterQueryBuilder appSubscriptionOperationsCounterQueryBuilder, QueryBuilderParameter<string?>? kind = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });
            return WithObjectField("app_subscription_operations", alias, appSubscriptionOperationsCounterQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptAppSubscriptionOperations() =>
            ExceptField("app_subscription_operations");
        public QueryQueryBuilder WithAppsMonetizationInfo(AppsMonetizationInfoQueryBuilder appsMonetizationInfoQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("apps_monetization_info", alias, appsMonetizationInfoQueryBuilder, new GraphQlDirective?[] { include, skip });
        public QueryQueryBuilder ExceptAppsMonetizationInfo() =>
            ExceptField("apps_monetization_info");
        public QueryQueryBuilder WithAppsMonetizationStatus(AppMonetizationStatusQueryBuilder appMonetizationStatusQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("apps_monetization_status", alias, appMonetizationStatusQueryBuilder, new GraphQlDirective?[] { include, skip });
        public QueryQueryBuilder ExceptAppsMonetizationStatus() =>
            ExceptField("apps_monetization_status");
        public QueryQueryBuilder WithAssets(AssetQueryBuilder assetQueryBuilder, QueryBuilderParameter<IEnumerable<string>> ids, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids }
            };
            return WithObjectField("assets", alias, assetQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptAssets() =>
            ExceptField("assets");
        public QueryQueryBuilder WithBoards(BoardQueryBuilder boardQueryBuilder, QueryBuilderParameter<BoardKind?>? boardKind = null, QueryBuilderParameter<IEnumerable<BoardHierarchy>>? hierarchyTypes = null, QueryBuilderParameter<IEnumerable<string>>? ids = null, QueryBuilderParameter<bool?>? latest = null, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<BoardsOrderBy?>? orderBy = null, QueryBuilderParameter<int?>? page = null, QueryBuilderParameter<State?>? state = null, QueryBuilderParameter<IEnumerable<string?>>? workspaceIDs = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (boardKind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_kind", ArgumentValue = boardKind });
            if (hierarchyTypes != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "hierarchy_types", ArgumentValue = hierarchyTypes });
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            if (latest != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "latest", ArgumentValue = latest });
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (orderBy != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "order_by", ArgumentValue = orderBy });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            if (state != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "state", ArgumentValue = state });
            if (workspaceIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_ids", ArgumentValue = workspaceIDs });
            return WithObjectField("boards", alias, boardQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptBoards() =>
            ExceptField("boards");
        public QueryQueryBuilder WithComplexity(ComplexityQueryBuilder complexityQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("complexity", alias, complexityQueryBuilder, new GraphQlDirective?[] { include, skip });
        public QueryQueryBuilder ExceptComplexity() =>
            ExceptField("complexity");
        public QueryQueryBuilder WithDocs(DocumentQueryBuilder documentQueryBuilder, QueryBuilderParameter<IEnumerable<string>>? ids = null, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<IEnumerable<string>>? objectIDs = null, QueryBuilderParameter<DocsOrderBy?>? orderBy = null, QueryBuilderParameter<int?>? page = null, QueryBuilderParameter<IEnumerable<string?>>? workspaceIDs = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (objectIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "object_ids", ArgumentValue = objectIDs });
            if (orderBy != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "order_by", ArgumentValue = orderBy });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            if (workspaceIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_ids", ArgumentValue = workspaceIDs });
            return WithObjectField("docs", alias, documentQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptDocs() =>
            ExceptField("docs");
        public QueryQueryBuilder WithFolders(FolderQueryBuilder folderQueryBuilder, QueryBuilderParameter<IEnumerable<string>>? ids = null, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<int?>? page = null, QueryBuilderParameter<IEnumerable<string?>>? workspaceIDs = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            if (workspaceIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_ids", ArgumentValue = workspaceIDs });
            return WithObjectField("folders", alias, folderQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptFolders() =>
            ExceptField("folders");
        public QueryQueryBuilder WithItems(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<bool?>? excludeNonactive = null, QueryBuilderParameter<IEnumerable<string>>? ids = null, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<bool?>? newestFirst = null, QueryBuilderParameter<int?>? page = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (excludeNonactive != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "exclude_nonactive", ArgumentValue = excludeNonactive });
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (newestFirst != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "newest_first", ArgumentValue = newestFirst });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            return WithObjectField("items", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptItems() =>
            ExceptField("items");
        public QueryQueryBuilder WithItemsPageByColumnValues(ItemsResponseQueryBuilder itemsResponseQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<int> limit, QueryBuilderParameter<IEnumerable<ItemsPageByColumnValuesQuery>>? columns = null, QueryBuilderParameter<string?>? cursor = null, QueryBuilderParameter<string?>? hierarchyScopeConfig = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            if (columns != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "columns", ArgumentValue = columns });
            if (cursor != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "cursor", ArgumentValue = cursor });
            if (hierarchyScopeConfig != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "hierarchy_scope_config", ArgumentValue = hierarchyScopeConfig });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            return WithObjectField("items_page_by_column_values", alias, itemsResponseQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptItemsPageByColumnValues() =>
            ExceptField("items_page_by_column_values");
        public QueryQueryBuilder WithMe(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("me", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public QueryQueryBuilder ExceptMe() =>
            ExceptField("me");
        public QueryQueryBuilder WithNextItemsPage(ItemsResponseQueryBuilder itemsResponseQueryBuilder, QueryBuilderParameter<string> cursor, QueryBuilderParameter<int> limit, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "cursor", ArgumentValue = cursor },
                new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit }
            };
            return WithObjectField("next_items_page", alias, itemsResponseQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptNextItemsPage() =>
            ExceptField("next_items_page");
        public QueryQueryBuilder WithTags(TagQueryBuilder tagQueryBuilder, QueryBuilderParameter<IEnumerable<string>>? ids = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            return WithObjectField("tags", alias, tagQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptTags() =>
            ExceptField("tags");
        public QueryQueryBuilder WithTeams(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<IEnumerable<string>>? ids = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            return WithObjectField("teams", alias, teamQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptTeams() =>
            ExceptField("teams");
        public QueryQueryBuilder WithUsers(UserQueryBuilder userQueryBuilder, QueryBuilderParameter<IEnumerable<string?>>? emails = null, QueryBuilderParameter<IEnumerable<string>>? ids = null, QueryBuilderParameter<UserKind?>? kind = null, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<string?>? name = null, QueryBuilderParameter<bool?>? newestFirst = null, QueryBuilderParameter<bool?>? nonActive = null, QueryBuilderParameter<int?>? page = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (emails != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "emails", ArgumentValue = emails });
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (name != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name });
            if (newestFirst != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "newest_first", ArgumentValue = newestFirst });
            if (nonActive != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "non_active", ArgumentValue = nonActive });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            return WithObjectField("users", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptUsers() =>
            ExceptField("users");
        public QueryQueryBuilder WithWebhooks(WebhookQueryBuilder webhookQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<bool?>? appWebhooksOnly = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (appWebhooksOnly != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "app_webhooks_only", ArgumentValue = appWebhooksOnly });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID });
            return WithObjectField("webhooks", alias, webhookQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptWebhooks() =>
            ExceptField("webhooks");
        public QueryQueryBuilder WithWorkspaces(WorkspaceQueryBuilder workspaceQueryBuilder, QueryBuilderParameter<IEnumerable<string>>? ids = null, QueryBuilderParameter<WorkspaceKind?>? kind = null, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<WorkspacesOrderBy?>? orderBy = null, QueryBuilderParameter<int?>? page = null, QueryBuilderParameter<State?>? state = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (orderBy != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "order_by", ArgumentValue = orderBy });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            if (state != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "state", ArgumentValue = state });
            return WithObjectField("workspaces", alias, workspaceQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptWorkspaces() =>
            ExceptField("workspaces");
        public QueryQueryBuilder WithBoardCandidates(BoardQueryBuilder boardQueryBuilder, QueryBuilderParameter<string> workspaceID, QueryBuilderParameter<BoardUsage> usageType, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "workspaceId", ArgumentValue = workspaceID },
                new QueryBuilderArgumentInfo { ArgumentName = "usageType", ArgumentValue = usageType }
            };
            return WithObjectField("board_candidates", alias, boardQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptBoardCandidates() =>
            ExceptField("board_candidates");
        public QueryQueryBuilder WithNotifications(NotificationV2QueryBuilder notificationV2QueryBuilder, QueryBuilderParameter<string?>? cursor = null, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<bool?>? filterRead = null, QueryBuilderParameter<object?>? since = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (cursor != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "cursor", ArgumentValue = cursor });
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (filterRead != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "filter_read", ArgumentValue = filterRead });
            if (since != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "since", ArgumentValue = since });
            return WithObjectField("notifications", alias, notificationV2QueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptNotifications() =>
            ExceptField("notifications");
        public QueryQueryBuilder WithNotificationsSettings(NotificationSettingQueryBuilder notificationSettingQueryBuilder, QueryBuilderParameter<ScopeType> scopeType, QueryBuilderParameter<int?>? scopeID = null, QueryBuilderParameter<IEnumerable<string>>? settingKinds = null, QueryBuilderParameter<IEnumerable<ChannelType>>? channels = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "scope_type", ArgumentValue = scopeType }
            };
            if (scopeID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "scope_id", ArgumentValue = scopeID });
            if (settingKinds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "setting_kinds", ArgumentValue = settingKinds });
            if (channels != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "channels", ArgumentValue = channels });
            return WithObjectField("notifications_settings", alias, notificationSettingQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptNotificationsSettings() =>
            ExceptField("notifications_settings");
        public QueryQueryBuilder WithMuteBoardSettings(BoardMuteSettingsQueryBuilder boardMuteSettingsQueryBuilder, QueryBuilderParameter<IEnumerable<string>> boardIDs, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_ids", ArgumentValue = boardIDs }
            };
            return WithObjectField("mute_board_settings", alias, boardMuteSettingsQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptMuteBoardSettings() =>
            ExceptField("mute_board_settings");
        public QueryQueryBuilder WithObjectTypesUniqueKeys(ObjectTypeUniqueKeyQueryBuilder objectTypeUniqueKeyQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("object_types_unique_keys", alias, objectTypeUniqueKeyQueryBuilder, new GraphQlDirective?[] { include, skip });
        public QueryQueryBuilder ExceptObjectTypesUniqueKeys() =>
            ExceptField("object_types_unique_keys");
        public QueryQueryBuilder WithObjects(ObjectQueryBuilder objectQueryBuilder, QueryBuilderParameter<IEnumerable<string>>? objectTypeUniqueKeys = null, QueryBuilderParameter<IEnumerable<string>>? ids = null, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<OrderBy?>? orderBy = null, QueryBuilderParameter<ObjectState?>? state = null, QueryBuilderParameter<PrivacyKind?>? privacyKind = null, QueryBuilderParameter<IEnumerable<string>>? workspaceIDs = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (objectTypeUniqueKeys != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "object_type_unique_keys", ArgumentValue = objectTypeUniqueKeys });
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (orderBy != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "order_by", ArgumentValue = orderBy });
            if (state != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "state", ArgumentValue = state });
            if (privacyKind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "privacy_kind", ArgumentValue = privacyKind });
            if (workspaceIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_ids", ArgumentValue = workspaceIDs });
            return WithObjectField("objects", alias, objectQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptObjects() =>
            ExceptField("objects");
        public QueryQueryBuilder WithVersion(VersionQueryBuilder versionQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("version", alias, versionQueryBuilder, new GraphQlDirective?[] { include, skip });
        public QueryQueryBuilder ExceptVersion() =>
            ExceptField("version");
        public QueryQueryBuilder WithVersions(VersionQueryBuilder versionQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("versions", alias, versionQueryBuilder, new GraphQlDirective?[] { include, skip });
        public QueryQueryBuilder ExceptVersions() =>
            ExceptField("versions");
        public QueryQueryBuilder WithPlatformAPI(PlatformAPIQueryBuilder platformAPIQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("platform_api", alias, platformAPIQueryBuilder, new GraphQlDirective?[] { include, skip });
        public QueryQueryBuilder ExceptPlatformAPI() =>
            ExceptField("platform_api");
        public QueryQueryBuilder WithAggregate(AggregateQueryResultQueryBuilder aggregateQueryResultQueryBuilder, QueryBuilderParameter<AggregateQueryInput> query, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "query", ArgumentValue = query }
            };
            return WithObjectField("aggregate", alias, aggregateQueryResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptAggregate() =>
            ExceptField("aggregate");
        public QueryQueryBuilder WithSprints(SprintQueryBuilder sprintQueryBuilder, QueryBuilderParameter<IEnumerable<string>> ids, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids }
            };
            return WithObjectField("sprints", alias, sprintQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptSprints() =>
            ExceptField("sprints");
        public QueryQueryBuilder WithAccountRoles(AccountRoleQueryBuilder accountRoleQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("account_roles", alias, accountRoleQueryBuilder, new GraphQlDirective?[] { include, skip });
        public QueryQueryBuilder ExceptAccountRoles() =>
            ExceptField("account_roles");
        public QueryQueryBuilder WithAllWidgetsSchema(WidgetSchemaInfoQueryBuilder widgetSchemaInfoQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("all_widgets_schema", alias, widgetSchemaInfoQueryBuilder, new GraphQlDirective?[] { include, skip });
        public QueryQueryBuilder ExceptAllWidgetsSchema() =>
            ExceptField("all_widgets_schema");
        public QueryQueryBuilder WithForm(ResponseFormQueryBuilder responseFormQueryBuilder, QueryBuilderParameter<string> formToken, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "formToken", ArgumentValue = formToken }
            };
            return WithObjectField("form", alias, responseFormQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder ExceptForm() =>
            ExceptField("form");
    }
}

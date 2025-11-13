using System;
using System.Collections.Generic;

namespace MondayApi.Schema {
    public class BoardQueryBuilder : GraphQlQueryBuilder<BoardQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "views", IsComplex = true, QueryBuilderType = typeof(BoardViewQueryBuilder) },
            new GraphQlFieldMetadata { Name = "updates", IsComplex = true, QueryBuilderType = typeof(UpdateQueryBuilder) },
            new GraphQlFieldMetadata { Name = "columns", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "access_level" },
            new GraphQlFieldMetadata { Name = "activity_logs", IsComplex = true, QueryBuilderType = typeof(ActivityLogTypeQueryBuilder) },
            new GraphQlFieldMetadata { Name = "board_folder_id" },
            new GraphQlFieldMetadata { Name = "board_kind" },
            new GraphQlFieldMetadata { Name = "columns_namespace" },
            new GraphQlFieldMetadata { Name = "communication" },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "creator", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "description" },
            new GraphQlFieldMetadata { Name = "groups", IsComplex = true, QueryBuilderType = typeof(GroupQueryBuilder) },
            new GraphQlFieldMetadata { Name = "hierarchy_type" },
            new GraphQlFieldMetadata { Name = "item_terminology" },
            new GraphQlFieldMetadata { Name = "items_count" },
            new GraphQlFieldMetadata { Name = "items_limit" },
            new GraphQlFieldMetadata { Name = "items_page", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemsResponseQueryBuilder) },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "object_type_unique_key" },
            new GraphQlFieldMetadata { Name = "owners", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "permissions" },
            new GraphQlFieldMetadata { Name = "state" },
            new GraphQlFieldMetadata { Name = "subscribers", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "tags", IsComplex = true, QueryBuilderType = typeof(TagQueryBuilder) },
            new GraphQlFieldMetadata { Name = "team_owners", IsComplex = true, QueryBuilderType = typeof(TeamQueryBuilder) },
            new GraphQlFieldMetadata { Name = "team_subscribers", IsComplex = true, QueryBuilderType = typeof(TeamQueryBuilder) },
            new GraphQlFieldMetadata { Name = "top_group", IsComplex = true, QueryBuilderType = typeof(GroupQueryBuilder) },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "url" },
            new GraphQlFieldMetadata { Name = "workspace", IsComplex = true, QueryBuilderType = typeof(WorkspaceQueryBuilder) },
            new GraphQlFieldMetadata { Name = "workspace_id" }
        };

        protected override string TypeName => "Board";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public BoardQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptID() =>
            ExceptField("id");
        public BoardQueryBuilder WithViews(BoardViewQueryBuilder boardViewQueryBuilder, QueryBuilderParameter<IEnumerable<string>>? ids = null, QueryBuilderParameter<string?>? type = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            if (type != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "type", ArgumentValue = type });
            return WithObjectField("views", alias, boardViewQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public BoardQueryBuilder ExceptViews() =>
            ExceptField("views");
        public BoardQueryBuilder WithUpdates(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<int?>? page = null, QueryBuilderParameter<IEnumerable<string>>? ids = null, QueryBuilderParameter<bool?>? boardUpdatesOnly = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            if (boardUpdatesOnly != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_updates_only", ArgumentValue = boardUpdatesOnly });
            return WithObjectField("updates", alias, updateQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public BoardQueryBuilder ExceptUpdates() =>
            ExceptField("updates");
        public BoardQueryBuilder WithColumns(ColumnQueryBuilder columnQueryBuilder, QueryBuilderParameter<IEnumerable<string?>>? ids = null, QueryBuilderParameter<IEnumerable<ColumnType>>? types = null, QueryBuilderParameter<IEnumerable<ColumnCapability>>? capabilities = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            if (types != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "types", ArgumentValue = types });
            if (capabilities != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "capabilities", ArgumentValue = capabilities });
            return WithObjectField("columns", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public BoardQueryBuilder ExceptColumns() =>
            ExceptField("columns");
        public BoardQueryBuilder WithAccessLevel(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("access_level", alias, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptAccessLevel() =>
            ExceptField("access_level");
        public BoardQueryBuilder WithActivityLogs(ActivityLogTypeQueryBuilder activityLogTypeQueryBuilder, QueryBuilderParameter<IEnumerable<string?>>? columnIDs = null, QueryBuilderParameter<DateTimeOffset?>? from = null, QueryBuilderParameter<IEnumerable<string?>>? groupIDs = null, QueryBuilderParameter<IEnumerable<string>>? itemIDs = null, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<int?>? page = null, QueryBuilderParameter<DateTimeOffset?>? to = null, QueryBuilderParameter<IEnumerable<string>>? userIDs = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (columnIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "column_ids", ArgumentValue = columnIDs });
            if (from != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "from", ArgumentValue = from });
            if (groupIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "group_ids", ArgumentValue = groupIDs });
            if (itemIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_ids", ArgumentValue = itemIDs });
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            if (to != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "to", ArgumentValue = to });
            if (userIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs });
            return WithObjectField("activity_logs", alias, activityLogTypeQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public BoardQueryBuilder ExceptActivityLogs() =>
            ExceptField("activity_logs");
        public BoardQueryBuilder WithBoardFolderID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("board_folder_id", alias, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptBoardFolderID() =>
            ExceptField("board_folder_id");
        public BoardQueryBuilder WithBoardKind(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("board_kind", alias, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptBoardKind() =>
            ExceptField("board_kind");
        public BoardQueryBuilder WithColumnsNamespace(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("columns_namespace", alias, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptColumnsNamespace() =>
            ExceptField("columns_namespace");
        public BoardQueryBuilder WithCommunication(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("communication", alias, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptCommunication() =>
            ExceptField("communication");
        public BoardQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public BoardQueryBuilder WithCreator(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("creator", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptCreator() =>
            ExceptField("creator");
        public BoardQueryBuilder WithDescription(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public BoardQueryBuilder WithGroups(GroupQueryBuilder groupQueryBuilder, QueryBuilderParameter<IEnumerable<string?>>? ids = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            return WithObjectField("groups", alias, groupQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public BoardQueryBuilder ExceptGroups() =>
            ExceptField("groups");
        public BoardQueryBuilder WithHierarchyType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("hierarchy_type", alias, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptHierarchyType() =>
            ExceptField("hierarchy_type");
        public BoardQueryBuilder WithItemTerminology(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("item_terminology", alias, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptItemTerminology() =>
            ExceptField("item_terminology");
        public BoardQueryBuilder WithItemsCount(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("items_count", alias, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptItemsCount() =>
            ExceptField("items_count");
        public BoardQueryBuilder WithItemsLimit(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("items_limit", alias, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptItemsLimit() =>
            ExceptField("items_limit");
        public BoardQueryBuilder WithItemsPage(ItemsResponseQueryBuilder itemsResponseQueryBuilder, QueryBuilderParameter<int> limit, QueryBuilderParameter<string?>? cursor = null, QueryBuilderParameter<string?>? hierarchyScopeConfig = null, QueryBuilderParameter<ItemsQuery?>? queryParams = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (cursor != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "cursor", ArgumentValue = cursor });
            if (hierarchyScopeConfig != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "hierarchy_scope_config", ArgumentValue = hierarchyScopeConfig });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (queryParams != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "query_params", ArgumentValue = queryParams });
            return WithObjectField("items_page", alias, itemsResponseQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public BoardQueryBuilder ExceptItemsPage() =>
            ExceptField("items_page");
        public BoardQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptName() =>
            ExceptField("name");
        public BoardQueryBuilder WithObjectTypeUniqueKey(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("object_type_unique_key", alias, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptObjectTypeUniqueKey() =>
            ExceptField("object_type_unique_key");
        public BoardQueryBuilder WithOwners(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("owners", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptOwners() =>
            ExceptField("owners");
        public BoardQueryBuilder WithPermissions(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("permissions", alias, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptPermissions() =>
            ExceptField("permissions");
        public BoardQueryBuilder WithState(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("state", alias, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptState() =>
            ExceptField("state");
        public BoardQueryBuilder WithSubscribers(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("subscribers", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptSubscribers() =>
            ExceptField("subscribers");
        public BoardQueryBuilder WithTags(TagQueryBuilder tagQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("tags", alias, tagQueryBuilder, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptTags() =>
            ExceptField("tags");
        public BoardQueryBuilder WithTeamOwners(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<int?>? page = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            return WithObjectField("team_owners", alias, teamQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public BoardQueryBuilder ExceptTeamOwners() =>
            ExceptField("team_owners");
        public BoardQueryBuilder WithTeamSubscribers(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<int?>? page = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            return WithObjectField("team_subscribers", alias, teamQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public BoardQueryBuilder ExceptTeamSubscribers() =>
            ExceptField("team_subscribers");
        public BoardQueryBuilder WithTopGroup(GroupQueryBuilder groupQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("top_group", alias, groupQueryBuilder, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptTopGroup() =>
            ExceptField("top_group");
        public BoardQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptType() =>
            ExceptField("type");
        public BoardQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public BoardQueryBuilder WithURL(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("url", alias, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptURL() =>
            ExceptField("url");
        public BoardQueryBuilder WithWorkspace(WorkspaceQueryBuilder workspaceQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("workspace", alias, workspaceQueryBuilder, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptWorkspace() =>
            ExceptField("workspace");
        public BoardQueryBuilder WithWorkspaceID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("workspace_id", alias, new GraphQlDirective?[] { include, skip });
        public BoardQueryBuilder ExceptWorkspaceID() =>
            ExceptField("workspace_id");
    }
}

using System;
using System.Collections.Generic;

namespace MondayApi.Schema {
    public class BoardQueryBuilder : GraphQlQueryBuilder<BoardQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new[]
            {
                new GraphQlFieldMetadata { Name = "activity_logs", IsComplex = true, QueryBuilderType = typeof(ActivityLogTypeQueryBuilder) },
                new GraphQlFieldMetadata { Name = "board_folder_id" },
                new GraphQlFieldMetadata { Name = "board_kind" },
                new GraphQlFieldMetadata { Name = "columns", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
                new GraphQlFieldMetadata { Name = "communication", IsComplex = true },
                new GraphQlFieldMetadata { Name = "creator", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
                new GraphQlFieldMetadata { Name = "description" },
                new GraphQlFieldMetadata { Name = "groups", IsComplex = true, QueryBuilderType = typeof(GroupQueryBuilder) },
                new GraphQlFieldMetadata { Name = "id" },
                new GraphQlFieldMetadata { Name = "item_terminology" },
                new GraphQlFieldMetadata { Name = "items_count" },
                new GraphQlFieldMetadata { Name = "name" },
                new GraphQlFieldMetadata { Name = "owners", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
                new GraphQlFieldMetadata { Name = "permissions" },
                new GraphQlFieldMetadata { Name = "state" },
                new GraphQlFieldMetadata { Name = "subscribers", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
                new GraphQlFieldMetadata { Name = "tags", IsComplex = true, QueryBuilderType = typeof(TagQueryBuilder) },
                new GraphQlFieldMetadata { Name = "team_owners", IsComplex = true, QueryBuilderType = typeof(TeamQueryBuilder) },
                new GraphQlFieldMetadata { Name = "top_group", IsComplex = true, QueryBuilderType = typeof(GroupQueryBuilder) },
                new GraphQlFieldMetadata { Name = "type" },
                new GraphQlFieldMetadata { Name = "updated_at" },
                new GraphQlFieldMetadata { Name = "updates", IsComplex = true, QueryBuilderType = typeof(UpdateQueryBuilder) },
                new GraphQlFieldMetadata { Name = "views", IsComplex = true, QueryBuilderType = typeof(BoardViewQueryBuilder) },
                new GraphQlFieldMetadata { Name = "workspace", IsComplex = true, QueryBuilderType = typeof(WorkspaceQueryBuilder) },
                new GraphQlFieldMetadata { Name = "workspace_id" }
            };

        protected override string TypeName { get { return "Board"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public BoardQueryBuilder WithActivityLogs(ActivityLogTypeQueryBuilder activityLogTypeQueryBuilder, QueryBuilderParameter<int?> limit = null, QueryBuilderParameter<int?> page = null, QueryBuilderParameter<IEnumerable<int?>> userIds = null, QueryBuilderParameter<IEnumerable<string>> columnIds = null, QueryBuilderParameter<IEnumerable<string>> groupIds = null, QueryBuilderParameter<IEnumerable<int?>> itemIds = null, QueryBuilderParameter<DateTimeOffset?> from = null, QueryBuilderParameter<DateTimeOffset?> to = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });

            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });

            if (userIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIds });

            if (columnIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "column_ids", ArgumentValue = columnIds });

            if (groupIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "group_ids", ArgumentValue = groupIds });

            if (itemIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_ids", ArgumentValue = itemIds });

            if (from != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "from", ArgumentValue = from });

            if (to != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "to", ArgumentValue = to });

            return WithObjectField("activity_logs", alias, activityLogTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public BoardQueryBuilder ExceptActivityLogs() {
            return ExceptField("activity_logs");
        }

        public BoardQueryBuilder WithBoardFolderId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("board_folder_id", alias, new GraphQlDirective[] { include, skip });
        }

        public BoardQueryBuilder ExceptBoardFolderId() {
            return ExceptField("board_folder_id");
        }

        public BoardQueryBuilder WithBoardKind(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("board_kind", alias, new GraphQlDirective[] { include, skip });
        }

        public BoardQueryBuilder ExceptBoardKind() {
            return ExceptField("board_kind");
        }

        public BoardQueryBuilder WithColumns(ColumnQueryBuilder columnQueryBuilder, QueryBuilderParameter<IEnumerable<string>> ids = null, QueryBuilderParameter<IEnumerable<string>> types = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });

            if (types != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "types", ArgumentValue = types });

            return WithObjectField("columns", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public BoardQueryBuilder ExceptColumns() {
            return ExceptField("columns");
        }

        public BoardQueryBuilder WithCommunication(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("communication", alias, new GraphQlDirective[] { include, skip });
        }

        public BoardQueryBuilder ExceptCommunication() {
            return ExceptField("communication");
        }

        public BoardQueryBuilder WithCreator(UserQueryBuilder userQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("creator", alias, userQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public BoardQueryBuilder ExceptCreator() {
            return ExceptField("creator");
        }

        public BoardQueryBuilder WithDescription(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("description", alias, new GraphQlDirective[] { include, skip });
        }

        public BoardQueryBuilder ExceptDescription() {
            return ExceptField("description");
        }

        public BoardQueryBuilder WithGroups(GroupQueryBuilder groupQueryBuilder, QueryBuilderParameter<IEnumerable<string>> ids = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });

            return WithObjectField("groups", alias, groupQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public BoardQueryBuilder ExceptGroups() {
            return ExceptField("groups");
        }

        public BoardQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public BoardQueryBuilder ExceptId() {
            return ExceptField("id");
        }

        public BoardQueryBuilder WithItemTerminology(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("item_terminology", alias, new GraphQlDirective[] { include, skip });
        }

        public BoardQueryBuilder ExceptItemTerminology() {
            return ExceptField("item_terminology");
        }

        public BoardQueryBuilder WithItemsCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("items_count", alias, new GraphQlDirective[] { include, skip });
        }

        public BoardQueryBuilder ExceptItemsCount() {
            return ExceptField("items_count");
        }

        public BoardQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        }

        public BoardQueryBuilder ExceptName() {
            return ExceptField("name");
        }

        public BoardQueryBuilder WithOwners(UserQueryBuilder userQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("owners", alias, userQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public BoardQueryBuilder ExceptOwners() {
            return ExceptField("owners");
        }

        public BoardQueryBuilder WithPermissions(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("permissions", alias, new GraphQlDirective[] { include, skip });
        }

        public BoardQueryBuilder ExceptPermissions() {
            return ExceptField("permissions");
        }

        public BoardQueryBuilder WithState(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("state", alias, new GraphQlDirective[] { include, skip });
        }

        public BoardQueryBuilder ExceptState() {
            return ExceptField("state");
        }

        public BoardQueryBuilder WithSubscribers(UserQueryBuilder userQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("subscribers", alias, userQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public BoardQueryBuilder ExceptSubscribers() {
            return ExceptField("subscribers");
        }

        public BoardQueryBuilder WithTags(TagQueryBuilder tagQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("tags", alias, tagQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public BoardQueryBuilder ExceptTags() {
            return ExceptField("tags");
        }

        public BoardQueryBuilder WithTeamOwners(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<int?> limit = null, QueryBuilderParameter<int?> page = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });

            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });

            return WithObjectField("team_owners", alias, teamQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public BoardQueryBuilder ExceptTeamOwners() {
            return ExceptField("team_owners");
        }

        public BoardQueryBuilder WithTopGroup(GroupQueryBuilder groupQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("top_group", alias, groupQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public BoardQueryBuilder ExceptTopGroup() {
            return ExceptField("top_group");
        }

        public BoardQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        }

        public BoardQueryBuilder ExceptType() {
            return ExceptField("type");
        }

        public BoardQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        }

        public BoardQueryBuilder ExceptUpdatedAt() {
            return ExceptField("updated_at");
        }

        public BoardQueryBuilder WithUpdates(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<int?> limit = null, QueryBuilderParameter<int?> page = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });

            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });

            return WithObjectField("updates", alias, updateQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public BoardQueryBuilder ExceptUpdates() {
            return ExceptField("updates");
        }

        public BoardQueryBuilder WithViews(BoardViewQueryBuilder boardViewQueryBuilder, QueryBuilderParameter<IEnumerable<int?>> ids = null, QueryBuilderParameter<string> type = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });

            if (type != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "type", ArgumentValue = type });

            return WithObjectField("views", alias, boardViewQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public BoardQueryBuilder ExceptViews() {
            return ExceptField("views");
        }

        public BoardQueryBuilder WithWorkspace(WorkspaceQueryBuilder workspaceQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("workspace", alias, workspaceQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public BoardQueryBuilder ExceptWorkspace() {
            return ExceptField("workspace");
        }

        public BoardQueryBuilder WithWorkspaceId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("workspace_id", alias, new GraphQlDirective[] { include, skip });
        }

        public BoardQueryBuilder ExceptWorkspaceId() {
            return ExceptField("workspace_id");
        }
    }
}

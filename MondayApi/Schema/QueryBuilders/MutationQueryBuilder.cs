using System;
using System.Collections.Generic;

namespace MondayApi.Schema {
    public class MutationQueryBuilder : GraphQlQueryBuilder<MutationQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "add_file_to_column", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AssetQueryBuilder) },
            new GraphQlFieldMetadata { Name = "add_file_to_update", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AssetQueryBuilder) },
            new GraphQlFieldMetadata { Name = "add_teams_to_board", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(TeamQueryBuilder) },
            new GraphQlFieldMetadata { Name = "add_teams_to_workspace", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(TeamQueryBuilder) },
            new GraphQlFieldMetadata { Name = "add_users_to_board", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "add_users_to_workspace", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "archive_board", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(BoardQueryBuilder) },
            new GraphQlFieldMetadata { Name = "archive_group", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(GroupQueryBuilder) },
            new GraphQlFieldMetadata { Name = "archive_item", IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "change_column_metadata", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "change_column_title", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "change_column_value", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "change_multiple_column_values", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "change_simple_column_value", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "clear_item_updates", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "complexity", IsComplex = true, QueryBuilderType = typeof(ComplexityQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_board", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(BoardQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_column", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_doc", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(DocumentQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_doc_block", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(DocumentBlockQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_folder", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(FolderQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_group", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(GroupQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_item", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_notification", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(NotificationQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_or_get_tag", IsComplex = true, QueryBuilderType = typeof(TagQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_subitem", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_update", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UpdateQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_webhook", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(WebhookQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_workspace", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(WorkspaceQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_board", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(BoardQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_column", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_doc_block", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(DocumentBlockIDOnlyQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_folder", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(FolderQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_group", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(GroupQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_item", IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_subscribers_from_board", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_teams_from_workspace", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(TeamQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_update", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UpdateQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_users_from_workspace", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_webhook", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(WebhookQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_workspace", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(WorkspaceQueryBuilder) },
            new GraphQlFieldMetadata { Name = "duplicate_board", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(BoardDuplicationQueryBuilder) },
            new GraphQlFieldMetadata { Name = "duplicate_group", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(GroupQueryBuilder) },
            new GraphQlFieldMetadata { Name = "duplicate_item", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "like_update", IsComplex = true, QueryBuilderType = typeof(UpdateQueryBuilder) },
            new GraphQlFieldMetadata { Name = "move_item_to_board", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "move_item_to_group", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "remove_mock_app_subscription", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AppSubscriptionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "set_mock_app_subscription", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AppSubscriptionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_board", RequiresParameters = true, IsComplex = true },
            new GraphQlFieldMetadata { Name = "update_doc_block", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(DocumentBlockQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_folder", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(FolderQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_group", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(GroupQueryBuilder) }
        };

        protected override string TypeName => "Mutation";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public MutationQueryBuilder WithAddFileToColumn(AssetQueryBuilder assetQueryBuilder, QueryBuilderParameter<string> itemID, QueryBuilderParameter<string> columnID, QueryBuilderParameter<object> file, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID },
                new QueryBuilderArgumentInfo { ArgumentName = "column_id", ArgumentValue = columnID },
                new QueryBuilderArgumentInfo { ArgumentName = "file", ArgumentValue = file }
            };
            return WithObjectField("add_file_to_column", alias, assetQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithAddFileToUpdate(AssetQueryBuilder assetQueryBuilder, QueryBuilderParameter<Guid> updateID, QueryBuilderParameter<object> file, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "update_id", ArgumentValue = updateID },
                new QueryBuilderArgumentInfo { ArgumentName = "file", ArgumentValue = file }
            };
            return WithObjectField("add_file_to_update", alias, assetQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithAddTeamsToBoard(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<IEnumerable<Guid>> teamIDs, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "team_ids", ArgumentValue = teamIDs }
            };
            return WithObjectField("add_teams_to_board", alias, teamQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithAddTeamsToWorkspace(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<Guid> workspaceID, QueryBuilderParameter<IEnumerable<Guid>> teamIDs, QueryBuilderParameter<WorkspaceSubscriberKind?> kind = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID },
                new QueryBuilderArgumentInfo { ArgumentName = "team_ids", ArgumentValue = teamIDs }
            };
            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });

            return WithObjectField("add_teams_to_workspace", alias, teamQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithAddUsersToBoard(UserQueryBuilder userQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<IEnumerable<Guid>> userIDs, QueryBuilderParameter<BoardSubscriberKind?> kind = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs }
            };
            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });

            return WithObjectField("add_users_to_board", alias, userQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithAddUsersToWorkspace(UserQueryBuilder userQueryBuilder, QueryBuilderParameter<Guid> workspaceID, QueryBuilderParameter<IEnumerable<Guid>> userIDs, QueryBuilderParameter<WorkspaceSubscriberKind?> kind = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID },
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs }
            };
            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });

            return WithObjectField("add_users_to_workspace", alias, userQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithArchiveBoard(BoardQueryBuilder boardQueryBuilder, QueryBuilderParameter<string> boardID, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            return WithObjectField("archive_board", alias, boardQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithArchiveGroup(GroupQueryBuilder groupQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> groupID, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "group_id", ArgumentValue = groupID }
            };
            return WithObjectField("archive_group", alias, groupQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithArchiveItem(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> itemID = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });

            return WithObjectField("archive_item", alias, itemQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithChangeColumnMetadata(ColumnQueryBuilder columnQueryBuilder, QueryBuilderParameter<string> columnID, QueryBuilderParameter<string> boardID, QueryBuilderParameter<ColumnProperty?> columnProperty = null, QueryBuilderParameter<string> value = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "column_id", ArgumentValue = columnID },
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            if (columnProperty != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "column_property", ArgumentValue = columnProperty });
            if (value != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "value", ArgumentValue = value });

            return WithObjectField("change_column_metadata", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithChangeColumnTitle(ColumnQueryBuilder columnQueryBuilder, QueryBuilderParameter<string> columnID, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> title, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "column_id", ArgumentValue = columnID },
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "title", ArgumentValue = title }
            };
            return WithObjectField("change_column_title", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithChangeColumnValue(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> columnID, QueryBuilderParameter<string> boardID, QueryBuilderParameter<object> value, QueryBuilderParameter<string> itemID = null, QueryBuilderParameter<bool?> createLabelsIfMissing = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "column_id", ArgumentValue = columnID },
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "value", ArgumentValue = value }
            };
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });
            if (createLabelsIfMissing != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "create_labels_if_missing", ArgumentValue = createLabelsIfMissing });

            return WithObjectField("change_column_value", alias, itemQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithChangeMultipleColumnValues(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> columnValues, QueryBuilderParameter<string> itemID = null, QueryBuilderParameter<bool?> createLabelsIfMissing = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "column_values", ArgumentValue = columnValues }
            };
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });
            if (createLabelsIfMissing != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "create_labels_if_missing", ArgumentValue = createLabelsIfMissing });

            return WithObjectField("change_multiple_column_values", alias, itemQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithChangeSimpleColumnValue(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> columnID, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> itemID = null, QueryBuilderParameter<string> value = null, QueryBuilderParameter<bool?> createLabelsIfMissing = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "column_id", ArgumentValue = columnID },
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });
            if (value != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "value", ArgumentValue = value });
            if (createLabelsIfMissing != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "create_labels_if_missing", ArgumentValue = createLabelsIfMissing });

            return WithObjectField("change_simple_column_value", alias, itemQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithClearItemUpdates(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> itemID, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID }
            };
            return WithObjectField("clear_item_updates", alias, itemQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateBoard(BoardQueryBuilder boardQueryBuilder, QueryBuilderParameter<string> boardName, QueryBuilderParameter<BoardKind> boardKind, QueryBuilderParameter<string> description = null, QueryBuilderParameter<string> folderID = null, QueryBuilderParameter<string> workspaceID = null, QueryBuilderParameter<string> templateID = null, QueryBuilderParameter<IEnumerable<string>> boardOwnerIDs = null, QueryBuilderParameter<IEnumerable<string>> boardOwnerTeamIDs = null, QueryBuilderParameter<IEnumerable<string>> boardSubscriberIDs = null, QueryBuilderParameter<IEnumerable<string>> boardSubscriberTeamsIDs = null, QueryBuilderParameter<bool?> empty = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_name", ArgumentValue = boardName },
                new QueryBuilderArgumentInfo { ArgumentName = "board_kind", ArgumentValue = boardKind }
            };
            if (description != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "description", ArgumentValue = description });
            if (folderID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "folder_id", ArgumentValue = folderID });
            if (workspaceID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID });
            if (templateID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "template_id", ArgumentValue = templateID });
            if (boardOwnerIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_owner_ids", ArgumentValue = boardOwnerIDs });
            if (boardOwnerTeamIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_owner_team_ids", ArgumentValue = boardOwnerTeamIDs });
            if (boardSubscriberIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_subscriber_ids", ArgumentValue = boardSubscriberIDs });
            if (boardSubscriberTeamsIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_subscriber_teams_ids", ArgumentValue = boardSubscriberTeamsIDs });
            if (empty != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "empty", ArgumentValue = empty });

            return WithObjectField("create_board", alias, boardQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateColumn(ColumnQueryBuilder columnQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> title, QueryBuilderParameter<ColumnType> columnType, QueryBuilderParameter<string> description = null, QueryBuilderParameter<object> defaults = null, QueryBuilderParameter<string> id = null, QueryBuilderParameter<Guid?> afterColumnID = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "title", ArgumentValue = title },
                new QueryBuilderArgumentInfo { ArgumentName = "column_type", ArgumentValue = columnType }
            };
            if (description != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "description", ArgumentValue = description });
            if (defaults != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "defaults", ArgumentValue = defaults });
            if (id != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id });
            if (afterColumnID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "after_column_id", ArgumentValue = afterColumnID });

            return WithObjectField("create_column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateDoc(DocumentQueryBuilder documentQueryBuilder, QueryBuilderParameter<CreateDocInput> location, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "location", ArgumentValue = location }
            };
            return WithObjectField("create_doc", alias, documentQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateDocBlock(DocumentBlockQueryBuilder documentBlockQueryBuilder, QueryBuilderParameter<Guid> docID, QueryBuilderParameter<DocBlockContentType> type, QueryBuilderParameter<object> content, QueryBuilderParameter<string> afterBlockID = null, QueryBuilderParameter<string> parentBlockID = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "doc_id", ArgumentValue = docID },
                new QueryBuilderArgumentInfo { ArgumentName = "type", ArgumentValue = type },
                new QueryBuilderArgumentInfo { ArgumentName = "content", ArgumentValue = content }
            };
            if (afterBlockID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "after_block_id", ArgumentValue = afterBlockID });
            if (parentBlockID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "parent_block_id", ArgumentValue = parentBlockID });

            return WithObjectField("create_doc_block", alias, documentBlockQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateFolder(FolderQueryBuilder folderQueryBuilder, QueryBuilderParameter<string> name, QueryBuilderParameter<Guid?> workspaceID = null, QueryBuilderParameter<FolderColor?> color = null, QueryBuilderParameter<Guid?> parentFolderID = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name }
            };
            if (workspaceID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID });
            if (color != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "color", ArgumentValue = color });
            if (parentFolderID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "parent_folder_id", ArgumentValue = parentFolderID });

            return WithObjectField("create_folder", alias, folderQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateGroup(GroupQueryBuilder groupQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> groupName, QueryBuilderParameter<string> position = null, QueryBuilderParameter<string> relativeTo = null, QueryBuilderParameter<PositionRelative?> positionRelativeMethod = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "group_name", ArgumentValue = groupName }
            };
            if (position != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "position", ArgumentValue = position });
            if (relativeTo != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "relative_to", ArgumentValue = relativeTo });
            if (positionRelativeMethod != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "position_relative_method", ArgumentValue = positionRelativeMethod });

            return WithObjectField("create_group", alias, groupQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateItem(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> itemName, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> groupID = null, QueryBuilderParameter<string> columnValues = null, QueryBuilderParameter<bool?> createLabelsIfMissing = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "item_name", ArgumentValue = itemName },
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            if (groupID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "group_id", ArgumentValue = groupID });
            if (columnValues != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "column_values", ArgumentValue = columnValues });
            if (createLabelsIfMissing != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "create_labels_if_missing", ArgumentValue = createLabelsIfMissing });

            return WithObjectField("create_item", alias, itemQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateNotification(NotificationQueryBuilder notificationQueryBuilder, QueryBuilderParameter<string> text, QueryBuilderParameter<Guid> userID, QueryBuilderParameter<Guid> targetID, QueryBuilderParameter<NotificationTargetType> targetType, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "text", ArgumentValue = text },
                new QueryBuilderArgumentInfo { ArgumentName = "user_id", ArgumentValue = userID },
                new QueryBuilderArgumentInfo { ArgumentName = "target_id", ArgumentValue = targetID },
                new QueryBuilderArgumentInfo { ArgumentName = "target_type", ArgumentValue = targetType }
            };
            return WithObjectField("create_notification", alias, notificationQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateOrGetTag(TagQueryBuilder tagQueryBuilder, QueryBuilderParameter<string> tagName = null, QueryBuilderParameter<string> boardID = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (tagName != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "tag_name", ArgumentValue = tagName });
            if (boardID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID });

            return WithObjectField("create_or_get_tag", alias, tagQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateSubitem(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> parentItemID, QueryBuilderParameter<string> itemName, QueryBuilderParameter<string> columnValues = null, QueryBuilderParameter<bool?> createLabelsIfMissing = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "parent_item_id", ArgumentValue = parentItemID },
                new QueryBuilderArgumentInfo { ArgumentName = "item_name", ArgumentValue = itemName }
            };
            if (columnValues != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "column_values", ArgumentValue = columnValues });
            if (createLabelsIfMissing != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "create_labels_if_missing", ArgumentValue = createLabelsIfMissing });

            return WithObjectField("create_subitem", alias, itemQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateUpdate(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<string> body, QueryBuilderParameter<string> itemID = null, QueryBuilderParameter<Guid?> parentID = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "body", ArgumentValue = body }
            };
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });
            if (parentID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "parent_id", ArgumentValue = parentID });

            return WithObjectField("create_update", alias, updateQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateWebhook(WebhookQueryBuilder webhookQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> url, QueryBuilderParameter<WebhookEventType> @event, QueryBuilderParameter<object> config = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "url", ArgumentValue = url },
                new QueryBuilderArgumentInfo { ArgumentName = "event", ArgumentValue = @event }
            };
            if (config != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "config", ArgumentValue = config });

            return WithObjectField("create_webhook", alias, webhookQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateWorkspace(WorkspaceQueryBuilder workspaceQueryBuilder, QueryBuilderParameter<string> name, QueryBuilderParameter<WorkspaceKind> kind, QueryBuilderParameter<string> description = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name },
                new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind }
            };
            if (description != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "description", ArgumentValue = description });

            return WithObjectField("create_workspace", alias, workspaceQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteBoard(BoardQueryBuilder boardQueryBuilder, QueryBuilderParameter<string> boardID, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            return WithObjectField("delete_board", alias, boardQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteColumn(ColumnQueryBuilder columnQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> columnID, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "column_id", ArgumentValue = columnID }
            };
            return WithObjectField("delete_column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteDocBlock(DocumentBlockIDOnlyQueryBuilder documentBlockIDOnlyQueryBuilder, QueryBuilderParameter<string> blockID, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "block_id", ArgumentValue = blockID }
            };
            return WithObjectField("delete_doc_block", alias, documentBlockIDOnlyQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteFolder(FolderQueryBuilder folderQueryBuilder, QueryBuilderParameter<Guid> folderID, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "folder_id", ArgumentValue = folderID }
            };
            return WithObjectField("delete_folder", alias, folderQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteGroup(GroupQueryBuilder groupQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> groupID, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "group_id", ArgumentValue = groupID }
            };
            return WithObjectField("delete_group", alias, groupQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteItem(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> itemID = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });

            return WithObjectField("delete_item", alias, itemQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteSubscribersFromBoard(UserQueryBuilder userQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<IEnumerable<Guid>> userIDs, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs }
            };
            return WithObjectField("delete_subscribers_from_board", alias, userQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteTeamsFromWorkspace(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<Guid> workspaceID, QueryBuilderParameter<IEnumerable<Guid>> teamIDs, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID },
                new QueryBuilderArgumentInfo { ArgumentName = "team_ids", ArgumentValue = teamIDs }
            };
            return WithObjectField("delete_teams_from_workspace", alias, teamQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteUpdate(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<Guid> id, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("delete_update", alias, updateQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteUsersFromWorkspace(UserQueryBuilder userQueryBuilder, QueryBuilderParameter<Guid> workspaceID, QueryBuilderParameter<IEnumerable<Guid>> userIDs, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID },
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs }
            };
            return WithObjectField("delete_users_from_workspace", alias, userQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteWebhook(WebhookQueryBuilder webhookQueryBuilder, QueryBuilderParameter<Guid> id, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("delete_webhook", alias, webhookQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteWorkspace(WorkspaceQueryBuilder workspaceQueryBuilder, QueryBuilderParameter<string> workspaceID, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID }
            };
            return WithObjectField("delete_workspace", alias, workspaceQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDuplicateBoard(BoardDuplicationQueryBuilder boardDuplicationQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<DuplicateBoardType> duplicateType, QueryBuilderParameter<string> boardName = null, QueryBuilderParameter<Guid?> workspaceID = null, QueryBuilderParameter<Guid?> folderID = null, QueryBuilderParameter<bool?> keepSubscribers = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "duplicate_type", ArgumentValue = duplicateType }
            };
            if (boardName != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_name", ArgumentValue = boardName });
            if (workspaceID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID });
            if (folderID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "folder_id", ArgumentValue = folderID });
            if (keepSubscribers != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "keep_subscribers", ArgumentValue = keepSubscribers });

            return WithObjectField("duplicate_board", alias, boardDuplicationQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDuplicateGroup(GroupQueryBuilder groupQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> groupID, QueryBuilderParameter<bool?> addToTop = null, QueryBuilderParameter<string> groupTitle = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "group_id", ArgumentValue = groupID }
            };
            if (addToTop != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "add_to_top", ArgumentValue = addToTop });
            if (groupTitle != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "group_title", ArgumentValue = groupTitle });

            return WithObjectField("duplicate_group", alias, groupQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDuplicateItem(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<bool?> withUpdates = null, QueryBuilderParameter<string> itemID = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            if (withUpdates != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "with_updates", ArgumentValue = withUpdates });
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });

            return WithObjectField("duplicate_item", alias, itemQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithLikeUpdate(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<Guid?> updateID = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (updateID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "update_id", ArgumentValue = updateID });

            return WithObjectField("like_update", alias, updateQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithMoveItemToBoard(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> groupID, QueryBuilderParameter<string> itemID, QueryBuilderParameter<IEnumerable<ColumnMappingInput>> columnsMapping = null, QueryBuilderParameter<IEnumerable<ColumnMappingInput>> subitemsColumnsMapping = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "group_id", ArgumentValue = groupID },
                new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID }
            };
            if (columnsMapping != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "columns_mapping", ArgumentValue = columnsMapping });
            if (subitemsColumnsMapping != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "subitems_columns_mapping", ArgumentValue = subitemsColumnsMapping });

            return WithObjectField("move_item_to_board", alias, itemQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithMoveItemToGroup(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> groupID, QueryBuilderParameter<string> itemID = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "group_id", ArgumentValue = groupID }
            };
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });

            return WithObjectField("move_item_to_group", alias, itemQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithRemoveMockAppSubscription(AppSubscriptionQueryBuilder appSubscriptionQueryBuilder, QueryBuilderParameter<Guid> appID, QueryBuilderParameter<string> partialSigningSecret, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "app_id", ArgumentValue = appID },
                new QueryBuilderArgumentInfo { ArgumentName = "partial_signing_secret", ArgumentValue = partialSigningSecret }
            };
            return WithObjectField("remove_mock_app_subscription", alias, appSubscriptionQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithSetMockAppSubscription(AppSubscriptionQueryBuilder appSubscriptionQueryBuilder, QueryBuilderParameter<Guid> appID, QueryBuilderParameter<string> partialSigningSecret, QueryBuilderParameter<string> planID = null, QueryBuilderParameter<bool?> isTrial = null, QueryBuilderParameter<object> renewalDate = null, QueryBuilderParameter<string> billingPeriod = null, QueryBuilderParameter<int?> pricingVersion = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "app_id", ArgumentValue = appID },
                new QueryBuilderArgumentInfo { ArgumentName = "partial_signing_secret", ArgumentValue = partialSigningSecret }
            };
            if (planID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "plan_id", ArgumentValue = planID });
            if (isTrial != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "is_trial", ArgumentValue = isTrial });
            if (renewalDate != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "renewal_date", ArgumentValue = renewalDate });
            if (billingPeriod != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "billing_period", ArgumentValue = billingPeriod });
            if (pricingVersion != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "pricing_version", ArgumentValue = pricingVersion });

            return WithObjectField("set_mock_app_subscription", alias, appSubscriptionQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithUpdateBoard(QueryBuilderParameter<string> boardID, QueryBuilderParameter<BoardAttributes> boardAttribute, QueryBuilderParameter<string> newValue, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "board_attribute", ArgumentValue = boardAttribute },
                new QueryBuilderArgumentInfo { ArgumentName = "new_value", ArgumentValue = newValue }
            };
            return WithScalarField("update_board", alias, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithUpdateDocBlock(DocumentBlockQueryBuilder documentBlockQueryBuilder, QueryBuilderParameter<string> blockID, QueryBuilderParameter<object> content, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "block_id", ArgumentValue = blockID },
                new QueryBuilderArgumentInfo { ArgumentName = "content", ArgumentValue = content }
            };
            return WithObjectField("update_doc_block", alias, documentBlockQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithUpdateFolder(FolderQueryBuilder folderQueryBuilder, QueryBuilderParameter<Guid> folderID, QueryBuilderParameter<string> name = null, QueryBuilderParameter<FolderColor?> color = null, QueryBuilderParameter<Guid?> parentFolderID = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "folder_id", ArgumentValue = folderID }
            };
            if (name != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name });
            if (color != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "color", ArgumentValue = color });
            if (parentFolderID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "parent_folder_id", ArgumentValue = parentFolderID });

            return WithObjectField("update_folder", alias, folderQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public MutationQueryBuilder WithUpdateGroup(GroupQueryBuilder groupQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> groupID, QueryBuilderParameter<GroupAttributes> groupAttribute, QueryBuilderParameter<string> newValue, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "group_id", ArgumentValue = groupID },
                new QueryBuilderArgumentInfo { ArgumentName = "group_attribute", ArgumentValue = groupAttribute },
                new QueryBuilderArgumentInfo { ArgumentName = "new_value", ArgumentValue = newValue }
            };
            return WithObjectField("update_group", alias, groupQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public MutationQueryBuilder(string operationName = null) : base("mutation", operationName) { }
        public MutationQueryBuilder WithParameter<T>(GraphQlQueryParameter<T> parameter) =>
            WithParameterInternal(parameter);
        public MutationQueryBuilder ExceptAddFileToColumn() =>
            ExceptField("add_file_to_column");
        public MutationQueryBuilder ExceptAddFileToUpdate() =>
            ExceptField("add_file_to_update");
        public MutationQueryBuilder ExceptAddTeamsToBoard() =>
            ExceptField("add_teams_to_board");
        public MutationQueryBuilder ExceptAddTeamsToWorkspace() =>
            ExceptField("add_teams_to_workspace");
        public MutationQueryBuilder ExceptAddUsersToBoard() =>
            ExceptField("add_users_to_board");
        public MutationQueryBuilder ExceptAddUsersToWorkspace() =>
            ExceptField("add_users_to_workspace");
        public MutationQueryBuilder ExceptArchiveBoard() =>
            ExceptField("archive_board");
        public MutationQueryBuilder ExceptArchiveGroup() =>
            ExceptField("archive_group");
        public MutationQueryBuilder ExceptArchiveItem() =>
            ExceptField("archive_item");
        public MutationQueryBuilder ExceptChangeColumnMetadata() =>
            ExceptField("change_column_metadata");
        public MutationQueryBuilder ExceptChangeColumnTitle() =>
            ExceptField("change_column_title");
        public MutationQueryBuilder ExceptChangeColumnValue() =>
            ExceptField("change_column_value");
        public MutationQueryBuilder ExceptChangeMultipleColumnValues() =>
            ExceptField("change_multiple_column_values");
        public MutationQueryBuilder ExceptChangeSimpleColumnValue() =>
            ExceptField("change_simple_column_value");
        public MutationQueryBuilder ExceptClearItemUpdates() =>
            ExceptField("clear_item_updates");
        public MutationQueryBuilder WithComplexity(ComplexityQueryBuilder complexityQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("complexity", alias, complexityQueryBuilder, new GraphQlDirective[] { include, skip });
        public MutationQueryBuilder ExceptComplexity() =>
            ExceptField("complexity");
        public MutationQueryBuilder ExceptCreateBoard() =>
            ExceptField("create_board");
        public MutationQueryBuilder ExceptCreateColumn() =>
            ExceptField("create_column");
        public MutationQueryBuilder ExceptCreateDoc() =>
            ExceptField("create_doc");
        public MutationQueryBuilder ExceptCreateDocBlock() =>
            ExceptField("create_doc_block");
        public MutationQueryBuilder ExceptCreateFolder() =>
            ExceptField("create_folder");
        public MutationQueryBuilder ExceptCreateGroup() =>
            ExceptField("create_group");
        public MutationQueryBuilder ExceptCreateItem() =>
            ExceptField("create_item");
        public MutationQueryBuilder ExceptCreateNotification() =>
            ExceptField("create_notification");
        public MutationQueryBuilder ExceptCreateOrGetTag() =>
            ExceptField("create_or_get_tag");
        public MutationQueryBuilder ExceptCreateSubitem() =>
            ExceptField("create_subitem");
        public MutationQueryBuilder ExceptCreateUpdate() =>
            ExceptField("create_update");
        public MutationQueryBuilder ExceptCreateWebhook() =>
            ExceptField("create_webhook");
        public MutationQueryBuilder ExceptCreateWorkspace() =>
            ExceptField("create_workspace");
        public MutationQueryBuilder ExceptDeleteBoard() =>
            ExceptField("delete_board");
        public MutationQueryBuilder ExceptDeleteColumn() =>
            ExceptField("delete_column");
        public MutationQueryBuilder ExceptDeleteDocBlock() =>
            ExceptField("delete_doc_block");
        public MutationQueryBuilder ExceptDeleteFolder() =>
            ExceptField("delete_folder");
        public MutationQueryBuilder ExceptDeleteGroup() =>
            ExceptField("delete_group");
        public MutationQueryBuilder ExceptDeleteItem() =>
            ExceptField("delete_item");
        public MutationQueryBuilder ExceptDeleteSubscribersFromBoard() =>
            ExceptField("delete_subscribers_from_board");
        public MutationQueryBuilder ExceptDeleteTeamsFromWorkspace() =>
            ExceptField("delete_teams_from_workspace");
        public MutationQueryBuilder ExceptDeleteUpdate() =>
            ExceptField("delete_update");
        public MutationQueryBuilder ExceptDeleteUsersFromWorkspace() =>
            ExceptField("delete_users_from_workspace");
        public MutationQueryBuilder ExceptDeleteWebhook() =>
            ExceptField("delete_webhook");
        public MutationQueryBuilder ExceptDeleteWorkspace() =>
            ExceptField("delete_workspace");
        public MutationQueryBuilder ExceptDuplicateBoard() =>
            ExceptField("duplicate_board");
        public MutationQueryBuilder ExceptDuplicateGroup() =>
            ExceptField("duplicate_group");
        public MutationQueryBuilder ExceptDuplicateItem() =>
            ExceptField("duplicate_item");
        public MutationQueryBuilder ExceptLikeUpdate() =>
            ExceptField("like_update");
        public MutationQueryBuilder ExceptMoveItemToBoard() =>
            ExceptField("move_item_to_board");
        public MutationQueryBuilder ExceptMoveItemToGroup() =>
            ExceptField("move_item_to_group");
        public MutationQueryBuilder ExceptRemoveMockAppSubscription() =>
            ExceptField("remove_mock_app_subscription");
        public MutationQueryBuilder ExceptSetMockAppSubscription() =>
            ExceptField("set_mock_app_subscription");
        public MutationQueryBuilder ExceptUpdateBoard() =>
            ExceptField("update_board");
        public MutationQueryBuilder ExceptUpdateDocBlock() =>
            ExceptField("update_doc_block");
        public MutationQueryBuilder ExceptUpdateFolder() =>
            ExceptField("update_folder");
        public MutationQueryBuilder ExceptUpdateGroup() =>
            ExceptField("update_group");
    }
}

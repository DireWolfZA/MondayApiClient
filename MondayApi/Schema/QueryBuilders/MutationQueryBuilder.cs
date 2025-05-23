using System;
using System.Collections.Generic;

namespace MondayApi.Schema {
    public class MutationQueryBuilder : GraphQlQueryBuilder<MutationQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "like_update", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UpdateQueryBuilder) },
            new GraphQlFieldMetadata { Name = "unlike_update", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UpdateQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_update", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UpdateQueryBuilder) },
            new GraphQlFieldMetadata { Name = "edit_update", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UpdateQueryBuilder) },
            new GraphQlFieldMetadata { Name = "pin_to_top", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UpdateQueryBuilder) },
            new GraphQlFieldMetadata { Name = "unpin_from_top", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UpdateQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_update", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UpdateQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_timeline_item", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(TimelineItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_timeline_item", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(TimelineItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_custom_activity", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(CustomActivityQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_custom_activity", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(CustomActivityQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_dropdown_managed_column", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(DropdownManagedColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_status_managed_column", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(StatusManagedColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_dropdown_managed_column", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(DropdownManagedColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_status_managed_column", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(StatusManagedColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "activate_managed_column", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ManagedColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "deactivate_managed_column", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ManagedColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_managed_column", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ManagedColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "grant_marketplace_app_discount", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(GrantMarketplaceAppDiscountResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_marketplace_app_discount", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(DeleteMarketplaceAppDiscountResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "add_file_to_column", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AssetQueryBuilder) },
            new GraphQlFieldMetadata { Name = "add_file_to_update", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AssetQueryBuilder) },
            new GraphQlFieldMetadata { Name = "add_teams_to_board", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(TeamQueryBuilder) },
            new GraphQlFieldMetadata { Name = "add_teams_to_workspace", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(TeamQueryBuilder) },
            new GraphQlFieldMetadata { Name = "add_users_to_board", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "add_users_to_team", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ChangeTeamMembershipsResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "add_users_to_workspace", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "archive_board", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(BoardQueryBuilder) },
            new GraphQlFieldMetadata { Name = "archive_group", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(GroupQueryBuilder) },
            new GraphQlFieldMetadata { Name = "archive_item", IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "batch_extend_trial_period", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(BatchExtendTrialPeriodQueryBuilder) },
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
            new GraphQlFieldMetadata { Name = "create_webhook", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(WebhookQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_workspace", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(WorkspaceQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_board", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(BoardQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_column", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_doc_block", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(DocumentBlockIDOnlyQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_folder", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(FolderQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_group", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(GroupQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_item", IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_subscribers_from_board", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_teams_from_board", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(TeamQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_teams_from_workspace", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(TeamQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_users_from_workspace", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_webhook", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(WebhookQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_workspace", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(WorkspaceQueryBuilder) },
            new GraphQlFieldMetadata { Name = "duplicate_board", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(BoardDuplicationQueryBuilder) },
            new GraphQlFieldMetadata { Name = "duplicate_group", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(GroupQueryBuilder) },
            new GraphQlFieldMetadata { Name = "duplicate_item", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "increase_app_subscription_operations", IsComplex = true, QueryBuilderType = typeof(AppSubscriptionOperationsCounterQueryBuilder) },
            new GraphQlFieldMetadata { Name = "move_item_to_board", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "move_item_to_group", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "remove_mock_app_subscription", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AppSubscriptionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "remove_users_from_team", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ChangeTeamMembershipsResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "set_mock_app_subscription", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AppSubscriptionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_assets_on_item", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_board", RequiresParameters = true },
            new GraphQlFieldMetadata { Name = "update_doc_block", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(DocumentBlockQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_folder", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(FolderQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_group", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(GroupQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_workspace", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(WorkspaceQueryBuilder) },
            new GraphQlFieldMetadata { Name = "use_template", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(TemplateQueryBuilder) },
            new GraphQlFieldMetadata { Name = "connect_project_to_portfolio", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ConnectProjectResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_team", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(TeamQueryBuilder) },
            new GraphQlFieldMetadata { Name = "activate_users", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ActivateUsersResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "deactivate_users", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(DeactivateUsersResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_team", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(TeamQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_users_role", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UpdateUsersRoleResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "assign_team_owners", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AssignTeamOwnersResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "remove_team_owners", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(RemoveTeamOwnersResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_email_domain", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UpdateEmailDomainResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_multiple_users", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UpdateUserAttributesResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "invite_users", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(InviteUsersResultQueryBuilder) }
        };

        protected override string TypeName => "Mutation";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public MutationQueryBuilder WithLikeUpdate(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<string> updateID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "update_id", ArgumentValue = updateID }
            };
            return WithObjectField("like_update", alias, updateQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithUnlikeUpdate(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<string> updateID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "update_id", ArgumentValue = updateID }
            };
            return WithObjectField("unlike_update", alias, updateQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteUpdate(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<string> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("delete_update", alias, updateQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithEditUpdate(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<string> id, QueryBuilderParameter<string> body, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id },
                new QueryBuilderArgumentInfo { ArgumentName = "body", ArgumentValue = body }
            };
            return WithObjectField("edit_update", alias, updateQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithPinToTop(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<string> id, QueryBuilderParameter<string?>? itemID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });
            return WithObjectField("pin_to_top", alias, updateQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithUnpinFromTop(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<string> id, QueryBuilderParameter<string?>? itemID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });
            return WithObjectField("unpin_from_top", alias, updateQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateUpdate(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<string> body, QueryBuilderParameter<string?>? itemID = null, QueryBuilderParameter<string?>? parentID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "body", ArgumentValue = body }
            };
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });
            if (parentID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "parent_id", ArgumentValue = parentID });
            return WithObjectField("create_update", alias, updateQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateTimelineItem(TimelineItemQueryBuilder timelineItemQueryBuilder, QueryBuilderParameter<string> itemID, QueryBuilderParameter<string> title, QueryBuilderParameter<DateTimeOffset> timestamp, QueryBuilderParameter<string> customActivityID, QueryBuilderParameter<int?>? userID = null, QueryBuilderParameter<string?>? summary = null, QueryBuilderParameter<string?>? content = null, QueryBuilderParameter<string?>? location = null, QueryBuilderParameter<string?>? phone = null, QueryBuilderParameter<string?>? url = null, QueryBuilderParameter<TimelineItemTimeRange?>? timeRange = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID },
                new QueryBuilderArgumentInfo { ArgumentName = "title", ArgumentValue = title },
                new QueryBuilderArgumentInfo { ArgumentName = "timestamp", ArgumentValue = timestamp },
                new QueryBuilderArgumentInfo { ArgumentName = "custom_activity_id", ArgumentValue = customActivityID }
            };
            if (userID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "user_id", ArgumentValue = userID });
            if (summary != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "summary", ArgumentValue = summary });
            if (content != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "content", ArgumentValue = content });
            if (location != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "location", ArgumentValue = location });
            if (phone != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "phone", ArgumentValue = phone });
            if (url != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "url", ArgumentValue = url });
            if (timeRange != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "time_range", ArgumentValue = timeRange });
            return WithObjectField("create_timeline_item", alias, timelineItemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteTimelineItem(TimelineItemQueryBuilder timelineItemQueryBuilder, QueryBuilderParameter<string> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("delete_timeline_item", alias, timelineItemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateCustomActivity(CustomActivityQueryBuilder customActivityQueryBuilder, QueryBuilderParameter<string> name, QueryBuilderParameter<CustomActivityIcon> iconID, QueryBuilderParameter<CustomActivityColor> color, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name },
                new QueryBuilderArgumentInfo { ArgumentName = "icon_id", ArgumentValue = iconID },
                new QueryBuilderArgumentInfo { ArgumentName = "color", ArgumentValue = color }
            };
            return WithObjectField("create_custom_activity", alias, customActivityQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteCustomActivity(CustomActivityQueryBuilder customActivityQueryBuilder, QueryBuilderParameter<string> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("delete_custom_activity", alias, customActivityQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateDropdownManagedColumn(DropdownManagedColumnQueryBuilder dropdownManagedColumnQueryBuilder, QueryBuilderParameter<string> title, QueryBuilderParameter<string?>? description = null, QueryBuilderParameter<CreateDropdownColumnSettingsInput?>? settings = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "title", ArgumentValue = title }
            };
            if (description != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "description", ArgumentValue = description });
            if (settings != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "settings", ArgumentValue = settings });
            return WithObjectField("create_dropdown_managed_column", alias, dropdownManagedColumnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateStatusManagedColumn(StatusManagedColumnQueryBuilder statusManagedColumnQueryBuilder, QueryBuilderParameter<string> title, QueryBuilderParameter<string?>? description = null, QueryBuilderParameter<CreateStatusColumnSettingsInput?>? settings = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "title", ArgumentValue = title }
            };
            if (description != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "description", ArgumentValue = description });
            if (settings != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "settings", ArgumentValue = settings });
            return WithObjectField("create_status_managed_column", alias, statusManagedColumnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithUpdateDropdownManagedColumn(DropdownManagedColumnQueryBuilder dropdownManagedColumnQueryBuilder, QueryBuilderParameter<string> id, QueryBuilderParameter<int> revision, QueryBuilderParameter<string?>? title = null, QueryBuilderParameter<string?>? description = null, QueryBuilderParameter<UpdateDropdownColumnSettingsInput?>? settings = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id },
                new QueryBuilderArgumentInfo { ArgumentName = "revision", ArgumentValue = revision }
            };
            if (title != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "title", ArgumentValue = title });
            if (description != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "description", ArgumentValue = description });
            if (settings != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "settings", ArgumentValue = settings });
            return WithObjectField("update_dropdown_managed_column", alias, dropdownManagedColumnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithUpdateStatusManagedColumn(StatusManagedColumnQueryBuilder statusManagedColumnQueryBuilder, QueryBuilderParameter<string> id, QueryBuilderParameter<int> revision, QueryBuilderParameter<string?>? title = null, QueryBuilderParameter<string?>? description = null, QueryBuilderParameter<UpdateStatusColumnSettingsInput?>? settings = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id },
                new QueryBuilderArgumentInfo { ArgumentName = "revision", ArgumentValue = revision }
            };
            if (title != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "title", ArgumentValue = title });
            if (description != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "description", ArgumentValue = description });
            if (settings != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "settings", ArgumentValue = settings });
            return WithObjectField("update_status_managed_column", alias, statusManagedColumnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithActivateManagedColumn(ManagedColumnQueryBuilder managedColumnQueryBuilder, QueryBuilderParameter<string> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("activate_managed_column", alias, managedColumnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeactivateManagedColumn(ManagedColumnQueryBuilder managedColumnQueryBuilder, QueryBuilderParameter<string> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("deactivate_managed_column", alias, managedColumnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteManagedColumn(ManagedColumnQueryBuilder managedColumnQueryBuilder, QueryBuilderParameter<string> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("delete_managed_column", alias, managedColumnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithGrantMarketplaceAppDiscount(GrantMarketplaceAppDiscountResultQueryBuilder grantMarketplaceAppDiscountResultQueryBuilder, QueryBuilderParameter<string> appID, QueryBuilderParameter<string> accountSlug, QueryBuilderParameter<GrantMarketplaceAppDiscountData> data, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "app_id", ArgumentValue = appID },
                new QueryBuilderArgumentInfo { ArgumentName = "account_slug", ArgumentValue = accountSlug },
                new QueryBuilderArgumentInfo { ArgumentName = "data", ArgumentValue = data }
            };
            return WithObjectField("grant_marketplace_app_discount", alias, grantMarketplaceAppDiscountResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteMarketplaceAppDiscount(DeleteMarketplaceAppDiscountResultQueryBuilder deleteMarketplaceAppDiscountResultQueryBuilder, QueryBuilderParameter<string> appID, QueryBuilderParameter<string> accountSlug, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "app_id", ArgumentValue = appID },
                new QueryBuilderArgumentInfo { ArgumentName = "account_slug", ArgumentValue = accountSlug }
            };
            return WithObjectField("delete_marketplace_app_discount", alias, deleteMarketplaceAppDiscountResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithAddFileToColumn(AssetQueryBuilder assetQueryBuilder, QueryBuilderParameter<string> columnID, QueryBuilderParameter<object> file, QueryBuilderParameter<string> itemID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "column_id", ArgumentValue = columnID },
                new QueryBuilderArgumentInfo { ArgumentName = "file", ArgumentValue = file },
                new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID }
            };
            return WithObjectField("add_file_to_column", alias, assetQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithAddFileToUpdate(AssetQueryBuilder assetQueryBuilder, QueryBuilderParameter<object> file, QueryBuilderParameter<string> updateID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "file", ArgumentValue = file },
                new QueryBuilderArgumentInfo { ArgumentName = "update_id", ArgumentValue = updateID }
            };
            return WithObjectField("add_file_to_update", alias, assetQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithAddTeamsToBoard(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<IEnumerable<string>> teamIDs, QueryBuilderParameter<BoardSubscriberKind?>? kind = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "team_ids", ArgumentValue = teamIDs }
            };
            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });
            return WithObjectField("add_teams_to_board", alias, teamQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithAddTeamsToWorkspace(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<IEnumerable<string>> teamIDs, QueryBuilderParameter<string> workspaceID, QueryBuilderParameter<WorkspaceSubscriberKind?>? kind = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "team_ids", ArgumentValue = teamIDs },
                new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID }
            };
            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });
            return WithObjectField("add_teams_to_workspace", alias, teamQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithAddUsersToBoard(UserQueryBuilder userQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<IEnumerable<string>> userIDs, QueryBuilderParameter<BoardSubscriberKind?>? kind = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs }
            };
            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });
            return WithObjectField("add_users_to_board", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithAddUsersToTeam(ChangeTeamMembershipsResultQueryBuilder changeTeamMembershipsResultQueryBuilder, QueryBuilderParameter<string> teamID, QueryBuilderParameter<IEnumerable<string>> userIDs, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "team_id", ArgumentValue = teamID },
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs }
            };
            return WithObjectField("add_users_to_team", alias, changeTeamMembershipsResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithAddUsersToWorkspace(UserQueryBuilder userQueryBuilder, QueryBuilderParameter<IEnumerable<string>> userIDs, QueryBuilderParameter<string> workspaceID, QueryBuilderParameter<WorkspaceSubscriberKind?>? kind = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs },
                new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID }
            };
            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });
            return WithObjectField("add_users_to_workspace", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithArchiveBoard(BoardQueryBuilder boardQueryBuilder, QueryBuilderParameter<string> boardID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            return WithObjectField("archive_board", alias, boardQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithArchiveGroup(GroupQueryBuilder groupQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> groupID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "group_id", ArgumentValue = groupID }
            };
            return WithObjectField("archive_group", alias, groupQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithArchiveItem(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string?>? itemID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });
            return WithObjectField("archive_item", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithBatchExtendTrialPeriod(BatchExtendTrialPeriodQueryBuilder batchExtendTrialPeriodQueryBuilder, QueryBuilderParameter<IEnumerable<string>> accountSlugs, QueryBuilderParameter<string> appID, QueryBuilderParameter<int> durationInDays, QueryBuilderParameter<string> planID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "account_slugs", ArgumentValue = accountSlugs },
                new QueryBuilderArgumentInfo { ArgumentName = "app_id", ArgumentValue = appID },
                new QueryBuilderArgumentInfo { ArgumentName = "duration_in_days", ArgumentValue = durationInDays },
                new QueryBuilderArgumentInfo { ArgumentName = "plan_id", ArgumentValue = planID }
            };
            return WithObjectField("batch_extend_trial_period", alias, batchExtendTrialPeriodQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithChangeColumnMetadata(ColumnQueryBuilder columnQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> columnID, QueryBuilderParameter<ColumnProperty?>? columnProperty = null, QueryBuilderParameter<string?>? value = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "column_id", ArgumentValue = columnID }
            };
            if (columnProperty != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "column_property", ArgumentValue = columnProperty });
            if (value != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "value", ArgumentValue = value });
            return WithObjectField("change_column_metadata", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithChangeColumnTitle(ColumnQueryBuilder columnQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> columnID, QueryBuilderParameter<string> title, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "column_id", ArgumentValue = columnID },
                new QueryBuilderArgumentInfo { ArgumentName = "title", ArgumentValue = title }
            };
            return WithObjectField("change_column_title", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithChangeColumnValue(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> columnID, QueryBuilderParameter<string> value, QueryBuilderParameter<bool?>? createLabelsIfMissing = null, QueryBuilderParameter<string?>? itemID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "column_id", ArgumentValue = columnID },
                new QueryBuilderArgumentInfo { ArgumentName = "value", ArgumentValue = value }
            };
            if (createLabelsIfMissing != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "create_labels_if_missing", ArgumentValue = createLabelsIfMissing });
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });
            return WithObjectField("change_column_value", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithChangeMultipleColumnValues(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> columnValues, QueryBuilderParameter<bool?>? createLabelsIfMissing = null, QueryBuilderParameter<string?>? itemID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "column_values", ArgumentValue = columnValues }
            };
            if (createLabelsIfMissing != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "create_labels_if_missing", ArgumentValue = createLabelsIfMissing });
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });
            return WithObjectField("change_multiple_column_values", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithChangeSimpleColumnValue(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> columnID, QueryBuilderParameter<bool?>? createLabelsIfMissing = null, QueryBuilderParameter<string?>? itemID = null, QueryBuilderParameter<string?>? value = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "column_id", ArgumentValue = columnID }
            };
            if (createLabelsIfMissing != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "create_labels_if_missing", ArgumentValue = createLabelsIfMissing });
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });
            if (value != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "value", ArgumentValue = value });
            return WithObjectField("change_simple_column_value", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithClearItemUpdates(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> itemID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID }
            };
            return WithObjectField("clear_item_updates", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateBoard(BoardQueryBuilder boardQueryBuilder, QueryBuilderParameter<BoardKind> boardKind, QueryBuilderParameter<string> boardName, QueryBuilderParameter<IEnumerable<string>>? boardOwnerIDs = null, QueryBuilderParameter<IEnumerable<string>>? boardOwnerTeamIDs = null, QueryBuilderParameter<IEnumerable<string>>? boardSubscriberIDs = null, QueryBuilderParameter<IEnumerable<string>>? boardSubscriberTeamsIDs = null, QueryBuilderParameter<string?>? description = null, QueryBuilderParameter<bool?>? empty = null, QueryBuilderParameter<string?>? folderID = null, QueryBuilderParameter<string?>? templateID = null, QueryBuilderParameter<string?>? workspaceID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_kind", ArgumentValue = boardKind },
                new QueryBuilderArgumentInfo { ArgumentName = "board_name", ArgumentValue = boardName }
            };
            if (boardOwnerIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_owner_ids", ArgumentValue = boardOwnerIDs });
            if (boardOwnerTeamIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_owner_team_ids", ArgumentValue = boardOwnerTeamIDs });
            if (boardSubscriberIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_subscriber_ids", ArgumentValue = boardSubscriberIDs });
            if (boardSubscriberTeamsIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_subscriber_teams_ids", ArgumentValue = boardSubscriberTeamsIDs });
            if (description != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "description", ArgumentValue = description });
            if (empty != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "empty", ArgumentValue = empty });
            if (folderID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "folder_id", ArgumentValue = folderID });
            if (templateID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "template_id", ArgumentValue = templateID });
            if (workspaceID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID });
            return WithObjectField("create_board", alias, boardQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateColumn(ColumnQueryBuilder columnQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<ColumnType> columnType, QueryBuilderParameter<string> title, QueryBuilderParameter<string?>? afterColumnID = null, QueryBuilderParameter<object?>? defaults = null, QueryBuilderParameter<string?>? description = null, QueryBuilderParameter<string?>? id = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "column_type", ArgumentValue = columnType },
                new QueryBuilderArgumentInfo { ArgumentName = "title", ArgumentValue = title }
            };
            if (afterColumnID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "after_column_id", ArgumentValue = afterColumnID });
            if (defaults != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "defaults", ArgumentValue = defaults });
            if (description != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "description", ArgumentValue = description });
            if (id != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id });
            return WithObjectField("create_column", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateDoc(DocumentQueryBuilder documentQueryBuilder, QueryBuilderParameter<CreateDocInput> location, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "location", ArgumentValue = location }
            };
            return WithObjectField("create_doc", alias, documentQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateDocBlock(DocumentBlockQueryBuilder documentBlockQueryBuilder, QueryBuilderParameter<object> content, QueryBuilderParameter<string> docID, QueryBuilderParameter<DocBlockContentType> type, QueryBuilderParameter<string?>? afterBlockID = null, QueryBuilderParameter<string?>? parentBlockID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "content", ArgumentValue = content },
                new QueryBuilderArgumentInfo { ArgumentName = "doc_id", ArgumentValue = docID },
                new QueryBuilderArgumentInfo { ArgumentName = "type", ArgumentValue = type }
            };
            if (afterBlockID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "after_block_id", ArgumentValue = afterBlockID });
            if (parentBlockID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "parent_block_id", ArgumentValue = parentBlockID });
            return WithObjectField("create_doc_block", alias, documentBlockQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateFolder(FolderQueryBuilder folderQueryBuilder, QueryBuilderParameter<string> name, QueryBuilderParameter<FolderColor?>? color = null, QueryBuilderParameter<FolderCustomIcon?>? customIcon = null, QueryBuilderParameter<FolderFontWeight?>? fontWeight = null, QueryBuilderParameter<string?>? parentFolderID = null, QueryBuilderParameter<string?>? workspaceID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name }
            };
            if (color != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "color", ArgumentValue = color });
            if (customIcon != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "custom_icon", ArgumentValue = customIcon });
            if (fontWeight != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "font_weight", ArgumentValue = fontWeight });
            if (parentFolderID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "parent_folder_id", ArgumentValue = parentFolderID });
            if (workspaceID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID });
            return WithObjectField("create_folder", alias, folderQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateGroup(GroupQueryBuilder groupQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> groupName, QueryBuilderParameter<string?>? groupColor = null, QueryBuilderParameter<string?>? position = null, QueryBuilderParameter<PositionRelative?>? positionRelativeMethod = null, QueryBuilderParameter<string?>? relativeTo = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "group_name", ArgumentValue = groupName }
            };
            if (groupColor != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "group_color", ArgumentValue = groupColor });
            if (position != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "position", ArgumentValue = position });
            if (positionRelativeMethod != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "position_relative_method", ArgumentValue = positionRelativeMethod });
            if (relativeTo != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "relative_to", ArgumentValue = relativeTo });
            return WithObjectField("create_group", alias, groupQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateItem(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> itemName, QueryBuilderParameter<string?>? columnValues = null, QueryBuilderParameter<bool?>? createLabelsIfMissing = null, QueryBuilderParameter<string?>? groupID = null, QueryBuilderParameter<PositionRelative?>? positionRelativeMethod = null, QueryBuilderParameter<string?>? relativeTo = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "item_name", ArgumentValue = itemName }
            };
            if (columnValues != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "column_values", ArgumentValue = columnValues });
            if (createLabelsIfMissing != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "create_labels_if_missing", ArgumentValue = createLabelsIfMissing });
            if (groupID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "group_id", ArgumentValue = groupID });
            if (positionRelativeMethod != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "position_relative_method", ArgumentValue = positionRelativeMethod });
            if (relativeTo != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "relative_to", ArgumentValue = relativeTo });
            return WithObjectField("create_item", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateNotification(NotificationQueryBuilder notificationQueryBuilder, QueryBuilderParameter<string> targetID, QueryBuilderParameter<NotificationTargetType> targetType, QueryBuilderParameter<string> text, QueryBuilderParameter<string> userID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "target_id", ArgumentValue = targetID },
                new QueryBuilderArgumentInfo { ArgumentName = "target_type", ArgumentValue = targetType },
                new QueryBuilderArgumentInfo { ArgumentName = "text", ArgumentValue = text },
                new QueryBuilderArgumentInfo { ArgumentName = "user_id", ArgumentValue = userID }
            };
            return WithObjectField("create_notification", alias, notificationQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateOrGetTag(TagQueryBuilder tagQueryBuilder, QueryBuilderParameter<string?>? boardID = null, QueryBuilderParameter<string?>? tagName = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (boardID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID });
            if (tagName != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "tag_name", ArgumentValue = tagName });
            return WithObjectField("create_or_get_tag", alias, tagQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateSubitem(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> itemName, QueryBuilderParameter<string> parentItemID, QueryBuilderParameter<string?>? columnValues = null, QueryBuilderParameter<bool?>? createLabelsIfMissing = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "item_name", ArgumentValue = itemName },
                new QueryBuilderArgumentInfo { ArgumentName = "parent_item_id", ArgumentValue = parentItemID }
            };
            if (columnValues != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "column_values", ArgumentValue = columnValues });
            if (createLabelsIfMissing != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "create_labels_if_missing", ArgumentValue = createLabelsIfMissing });
            return WithObjectField("create_subitem", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateWebhook(WebhookQueryBuilder webhookQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<WebhookEventType> @event, QueryBuilderParameter<string> url, QueryBuilderParameter<object?>? config = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "event", ArgumentValue = @event },
                new QueryBuilderArgumentInfo { ArgumentName = "url", ArgumentValue = url }
            };
            if (config != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "config", ArgumentValue = config });
            return WithObjectField("create_webhook", alias, webhookQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateWorkspace(WorkspaceQueryBuilder workspaceQueryBuilder, QueryBuilderParameter<WorkspaceKind> kind, QueryBuilderParameter<string> name, QueryBuilderParameter<string?>? accountProductID = null, QueryBuilderParameter<string?>? description = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind },
                new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name }
            };
            if (accountProductID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "account_product_id", ArgumentValue = accountProductID });
            if (description != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "description", ArgumentValue = description });
            return WithObjectField("create_workspace", alias, workspaceQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteBoard(BoardQueryBuilder boardQueryBuilder, QueryBuilderParameter<string> boardID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            return WithObjectField("delete_board", alias, boardQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteColumn(ColumnQueryBuilder columnQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> columnID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "column_id", ArgumentValue = columnID }
            };
            return WithObjectField("delete_column", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteDocBlock(DocumentBlockIDOnlyQueryBuilder documentBlockIDOnlyQueryBuilder, QueryBuilderParameter<string> blockID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "block_id", ArgumentValue = blockID }
            };
            return WithObjectField("delete_doc_block", alias, documentBlockIDOnlyQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteFolder(FolderQueryBuilder folderQueryBuilder, QueryBuilderParameter<string> folderID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "folder_id", ArgumentValue = folderID }
            };
            return WithObjectField("delete_folder", alias, folderQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteGroup(GroupQueryBuilder groupQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> groupID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "group_id", ArgumentValue = groupID }
            };
            return WithObjectField("delete_group", alias, groupQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteItem(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string?>? itemID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });
            return WithObjectField("delete_item", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteSubscribersFromBoard(UserQueryBuilder userQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<IEnumerable<string>> userIDs, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs }
            };
            return WithObjectField("delete_subscribers_from_board", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteTeamsFromBoard(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<IEnumerable<string>> teamIDs, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "team_ids", ArgumentValue = teamIDs }
            };
            return WithObjectField("delete_teams_from_board", alias, teamQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteTeamsFromWorkspace(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<IEnumerable<string>> teamIDs, QueryBuilderParameter<string> workspaceID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "team_ids", ArgumentValue = teamIDs },
                new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID }
            };
            return WithObjectField("delete_teams_from_workspace", alias, teamQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteUsersFromWorkspace(UserQueryBuilder userQueryBuilder, QueryBuilderParameter<IEnumerable<string>> userIDs, QueryBuilderParameter<string> workspaceID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs },
                new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID }
            };
            return WithObjectField("delete_users_from_workspace", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteWebhook(WebhookQueryBuilder webhookQueryBuilder, QueryBuilderParameter<string> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("delete_webhook", alias, webhookQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteWorkspace(WorkspaceQueryBuilder workspaceQueryBuilder, QueryBuilderParameter<string> workspaceID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID }
            };
            return WithObjectField("delete_workspace", alias, workspaceQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDuplicateBoard(BoardDuplicationQueryBuilder boardDuplicationQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<DuplicateBoardType> duplicateType, QueryBuilderParameter<string?>? boardName = null, QueryBuilderParameter<string?>? folderID = null, QueryBuilderParameter<bool?>? keepSubscribers = null, QueryBuilderParameter<string?>? workspaceID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "duplicate_type", ArgumentValue = duplicateType }
            };
            if (boardName != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_name", ArgumentValue = boardName });
            if (folderID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "folder_id", ArgumentValue = folderID });
            if (keepSubscribers != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "keep_subscribers", ArgumentValue = keepSubscribers });
            if (workspaceID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID });
            return WithObjectField("duplicate_board", alias, boardDuplicationQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDuplicateGroup(GroupQueryBuilder groupQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> groupID, QueryBuilderParameter<bool?>? addToTop = null, QueryBuilderParameter<string?>? groupTitle = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "group_id", ArgumentValue = groupID }
            };
            if (addToTop != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "add_to_top", ArgumentValue = addToTop });
            if (groupTitle != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "group_title", ArgumentValue = groupTitle });
            return WithObjectField("duplicate_group", alias, groupQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDuplicateItem(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string?>? itemID = null, QueryBuilderParameter<bool?>? withUpdates = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });
            if (withUpdates != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "with_updates", ArgumentValue = withUpdates });
            return WithObjectField("duplicate_item", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithIncreaseAppSubscriptionOperations(AppSubscriptionOperationsCounterQueryBuilder appSubscriptionOperationsCounterQueryBuilder, QueryBuilderParameter<int?>? incrementBy = null, QueryBuilderParameter<string?>? kind = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (incrementBy != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "increment_by", ArgumentValue = incrementBy });
            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });
            return WithObjectField("increase_app_subscription_operations", alias, appSubscriptionOperationsCounterQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithMoveItemToBoard(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> groupID, QueryBuilderParameter<string> itemID, QueryBuilderParameter<IEnumerable<ColumnMappingInput>>? columnsMapping = null, QueryBuilderParameter<IEnumerable<ColumnMappingInput>>? subitemsColumnsMapping = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "group_id", ArgumentValue = groupID },
                new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID }
            };
            if (columnsMapping != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "columns_mapping", ArgumentValue = columnsMapping });
            if (subitemsColumnsMapping != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "subitems_columns_mapping", ArgumentValue = subitemsColumnsMapping });
            return WithObjectField("move_item_to_board", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithMoveItemToGroup(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> groupID, QueryBuilderParameter<string?>? itemID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "group_id", ArgumentValue = groupID }
            };
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });
            return WithObjectField("move_item_to_group", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithRemoveMockAppSubscription(AppSubscriptionQueryBuilder appSubscriptionQueryBuilder, QueryBuilderParameter<string> appID, QueryBuilderParameter<string> partialSigningSecret, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "app_id", ArgumentValue = appID },
                new QueryBuilderArgumentInfo { ArgumentName = "partial_signing_secret", ArgumentValue = partialSigningSecret }
            };
            return WithObjectField("remove_mock_app_subscription", alias, appSubscriptionQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithRemoveUsersFromTeam(ChangeTeamMembershipsResultQueryBuilder changeTeamMembershipsResultQueryBuilder, QueryBuilderParameter<string> teamID, QueryBuilderParameter<IEnumerable<string>> userIDs, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "team_id", ArgumentValue = teamID },
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs }
            };
            return WithObjectField("remove_users_from_team", alias, changeTeamMembershipsResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithSetMockAppSubscription(AppSubscriptionQueryBuilder appSubscriptionQueryBuilder, QueryBuilderParameter<string> appID, QueryBuilderParameter<string> partialSigningSecret, QueryBuilderParameter<string?>? billingPeriod = null, QueryBuilderParameter<bool?>? isTrial = null, QueryBuilderParameter<int?>? maxUnits = null, QueryBuilderParameter<string?>? planID = null, QueryBuilderParameter<int?>? pricingVersion = null, QueryBuilderParameter<object?>? renewalDate = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "app_id", ArgumentValue = appID },
                new QueryBuilderArgumentInfo { ArgumentName = "partial_signing_secret", ArgumentValue = partialSigningSecret }
            };
            if (billingPeriod != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "billing_period", ArgumentValue = billingPeriod });
            if (isTrial != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "is_trial", ArgumentValue = isTrial });
            if (maxUnits != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "max_units", ArgumentValue = maxUnits });
            if (planID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "plan_id", ArgumentValue = planID });
            if (pricingVersion != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "pricing_version", ArgumentValue = pricingVersion });
            if (renewalDate != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "renewal_date", ArgumentValue = renewalDate });
            return WithObjectField("set_mock_app_subscription", alias, appSubscriptionQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithUpdateAssetsOnItem(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> columnID, QueryBuilderParameter<IEnumerable<FileInput>> files, QueryBuilderParameter<string> itemID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "column_id", ArgumentValue = columnID },
                new QueryBuilderArgumentInfo { ArgumentName = "files", ArgumentValue = files },
                new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID }
            };
            return WithObjectField("update_assets_on_item", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithUpdateBoard(QueryBuilderParameter<BoardAttributes> boardAttribute, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> newValue, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_attribute", ArgumentValue = boardAttribute },
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "new_value", ArgumentValue = newValue }
            };
            return WithScalarField("update_board", alias, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithUpdateDocBlock(DocumentBlockQueryBuilder documentBlockQueryBuilder, QueryBuilderParameter<string> blockID, QueryBuilderParameter<object> content, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "block_id", ArgumentValue = blockID },
                new QueryBuilderArgumentInfo { ArgumentName = "content", ArgumentValue = content }
            };
            return WithObjectField("update_doc_block", alias, documentBlockQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithUpdateFolder(FolderQueryBuilder folderQueryBuilder, QueryBuilderParameter<string> folderID, QueryBuilderParameter<FolderColor?>? color = null, QueryBuilderParameter<FolderCustomIcon?>? customIcon = null, QueryBuilderParameter<FolderFontWeight?>? fontWeight = null, QueryBuilderParameter<string?>? name = null, QueryBuilderParameter<string?>? parentFolderID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "folder_id", ArgumentValue = folderID }
            };
            if (color != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "color", ArgumentValue = color });
            if (customIcon != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "custom_icon", ArgumentValue = customIcon });
            if (fontWeight != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "font_weight", ArgumentValue = fontWeight });
            if (name != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name });
            if (parentFolderID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "parent_folder_id", ArgumentValue = parentFolderID });
            return WithObjectField("update_folder", alias, folderQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithUpdateGroup(GroupQueryBuilder groupQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<GroupAttributes> groupAttribute, QueryBuilderParameter<string> groupID, QueryBuilderParameter<string> newValue, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "group_attribute", ArgumentValue = groupAttribute },
                new QueryBuilderArgumentInfo { ArgumentName = "group_id", ArgumentValue = groupID },
                new QueryBuilderArgumentInfo { ArgumentName = "new_value", ArgumentValue = newValue }
            };
            return WithObjectField("update_group", alias, groupQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithUpdateWorkspace(WorkspaceQueryBuilder workspaceQueryBuilder, QueryBuilderParameter<UpdateWorkspaceAttributesInput> attributes, QueryBuilderParameter<string?>? id = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "attributes", ArgumentValue = attributes }
            };
            if (id != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id });
            return WithObjectField("update_workspace", alias, workspaceQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithUseTemplate(TemplateQueryBuilder templateQueryBuilder, QueryBuilderParameter<int> templateID, QueryBuilderParameter<BoardKind?>? boardKind = null, QueryBuilderParameter<IEnumerable<int?>>? boardOwnerIDs = null, QueryBuilderParameter<IEnumerable<int?>>? boardOwnerTeamIDs = null, QueryBuilderParameter<IEnumerable<int?>>? boardSubscriberIDs = null, QueryBuilderParameter<IEnumerable<int?>>? boardSubscriberTeamsIDs = null, QueryBuilderParameter<string?>? callbackURLOnComplete = null, QueryBuilderParameter<int?>? destinationFolderID = null, QueryBuilderParameter<string?>? destinationFolderName = null, QueryBuilderParameter<string?>? destinationName = null, QueryBuilderParameter<int?>? destinationWorkspaceID = null, QueryBuilderParameter<bool?>? skipTargetFolderCreation = null, QueryBuilderParameter<object?>? solutionExtraOptions = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "template_id", ArgumentValue = templateID }
            };
            if (boardKind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_kind", ArgumentValue = boardKind });
            if (boardOwnerIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_owner_ids", ArgumentValue = boardOwnerIDs });
            if (boardOwnerTeamIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_owner_team_ids", ArgumentValue = boardOwnerTeamIDs });
            if (boardSubscriberIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_subscriber_ids", ArgumentValue = boardSubscriberIDs });
            if (boardSubscriberTeamsIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_subscriber_teams_ids", ArgumentValue = boardSubscriberTeamsIDs });
            if (callbackURLOnComplete != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "callback_url_on_complete", ArgumentValue = callbackURLOnComplete });
            if (destinationFolderID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "destination_folder_id", ArgumentValue = destinationFolderID });
            if (destinationFolderName != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "destination_folder_name", ArgumentValue = destinationFolderName });
            if (destinationName != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "destination_name", ArgumentValue = destinationName });
            if (destinationWorkspaceID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "destination_workspace_id", ArgumentValue = destinationWorkspaceID });
            if (skipTargetFolderCreation != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "skip_target_folder_creation", ArgumentValue = skipTargetFolderCreation });
            if (solutionExtraOptions != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "solution_extra_options", ArgumentValue = solutionExtraOptions });
            return WithObjectField("use_template", alias, templateQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithConnectProjectToPortfolio(ConnectProjectResultQueryBuilder connectProjectResultQueryBuilder, QueryBuilderParameter<string> projectBoardID, QueryBuilderParameter<string> portfolioBoardID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "projectBoardId", ArgumentValue = projectBoardID },
                new QueryBuilderArgumentInfo { ArgumentName = "portfolioBoardId", ArgumentValue = portfolioBoardID }
            };
            return WithObjectField("connect_project_to_portfolio", alias, connectProjectResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithCreateTeam(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<CreateTeamAttributesInput> input, QueryBuilderParameter<CreateTeamOptionsInput?>? options = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "input", ArgumentValue = input }
            };
            if (options != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "options", ArgumentValue = options });
            return WithObjectField("create_team", alias, teamQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithActivateUsers(ActivateUsersResultQueryBuilder activateUsersResultQueryBuilder, QueryBuilderParameter<IEnumerable<string>> userIDs, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs }
            };
            return WithObjectField("activate_users", alias, activateUsersResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeactivateUsers(DeactivateUsersResultQueryBuilder deactivateUsersResultQueryBuilder, QueryBuilderParameter<IEnumerable<string>> userIDs, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs }
            };
            return WithObjectField("deactivate_users", alias, deactivateUsersResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithDeleteTeam(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<string> teamID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "team_id", ArgumentValue = teamID }
            };
            return WithObjectField("delete_team", alias, teamQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithUpdateUsersRole(UpdateUsersRoleResultQueryBuilder updateUsersRoleResultQueryBuilder, QueryBuilderParameter<IEnumerable<string>> userIDs, QueryBuilderParameter<BaseRoleName?>? newRole = null, QueryBuilderParameter<string?>? roleID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs }
            };
            if (newRole != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "new_role", ArgumentValue = newRole });
            if (roleID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "role_id", ArgumentValue = roleID });
            return WithObjectField("update_users_role", alias, updateUsersRoleResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithAssignTeamOwners(AssignTeamOwnersResultQueryBuilder assignTeamOwnersResultQueryBuilder, QueryBuilderParameter<string> teamID, QueryBuilderParameter<IEnumerable<string>> userIDs, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "team_id", ArgumentValue = teamID },
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs }
            };
            return WithObjectField("assign_team_owners", alias, assignTeamOwnersResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithRemoveTeamOwners(RemoveTeamOwnersResultQueryBuilder removeTeamOwnersResultQueryBuilder, QueryBuilderParameter<string> teamID, QueryBuilderParameter<IEnumerable<string>> userIDs, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "team_id", ArgumentValue = teamID },
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs }
            };
            return WithObjectField("remove_team_owners", alias, removeTeamOwnersResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithUpdateEmailDomain(UpdateEmailDomainResultQueryBuilder updateEmailDomainResultQueryBuilder, QueryBuilderParameter<UpdateEmailDomainAttributesInput> input, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "input", ArgumentValue = input }
            };
            return WithObjectField("update_email_domain", alias, updateEmailDomainResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithUpdateMultipleUsers(UpdateUserAttributesResultQueryBuilder updateUserAttributesResultQueryBuilder, QueryBuilderParameter<IEnumerable<UserUpdateInput>> userUpdates, QueryBuilderParameter<bool?>? bypassConfirmationForClaimedDomains = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "user_updates", ArgumentValue = userUpdates }
            };
            if (bypassConfirmationForClaimedDomains != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "bypass_confirmation_for_claimed_domains", ArgumentValue = bypassConfirmationForClaimedDomains });
            return WithObjectField("update_multiple_users", alias, updateUserAttributesResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder WithInviteUsers(InviteUsersResultQueryBuilder inviteUsersResultQueryBuilder, QueryBuilderParameter<IEnumerable<string>> emails, QueryBuilderParameter<UserRole?>? userRole = null, QueryBuilderParameter<Product?>? product = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "emails", ArgumentValue = emails }
            };
            if (userRole != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "user_role", ArgumentValue = userRole });
            if (product != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "product", ArgumentValue = product });
            return WithObjectField("invite_users", alias, inviteUsersResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }

        public MutationQueryBuilder(string? operationName = null) : base("mutation", operationName) { }
        public MutationQueryBuilder WithParameter<T>(GraphQlQueryParameter<T> parameter) =>
            WithParameterInternal(parameter);
        public MutationQueryBuilder ExceptLikeUpdate() =>
            ExceptField("like_update");
        public MutationQueryBuilder ExceptUnlikeUpdate() =>
            ExceptField("unlike_update");
        public MutationQueryBuilder ExceptDeleteUpdate() =>
            ExceptField("delete_update");
        public MutationQueryBuilder ExceptEditUpdate() =>
            ExceptField("edit_update");
        public MutationQueryBuilder ExceptPinToTop() =>
            ExceptField("pin_to_top");
        public MutationQueryBuilder ExceptUnpinFromTop() =>
            ExceptField("unpin_from_top");
        public MutationQueryBuilder ExceptCreateUpdate() =>
            ExceptField("create_update");
        public MutationQueryBuilder ExceptCreateTimelineItem() =>
            ExceptField("create_timeline_item");
        public MutationQueryBuilder ExceptDeleteTimelineItem() =>
            ExceptField("delete_timeline_item");
        public MutationQueryBuilder ExceptCreateCustomActivity() =>
            ExceptField("create_custom_activity");
        public MutationQueryBuilder ExceptDeleteCustomActivity() =>
            ExceptField("delete_custom_activity");
        public MutationQueryBuilder ExceptCreateDropdownManagedColumn() =>
            ExceptField("create_dropdown_managed_column");
        public MutationQueryBuilder ExceptCreateStatusManagedColumn() =>
            ExceptField("create_status_managed_column");
        public MutationQueryBuilder ExceptUpdateDropdownManagedColumn() =>
            ExceptField("update_dropdown_managed_column");
        public MutationQueryBuilder ExceptUpdateStatusManagedColumn() =>
            ExceptField("update_status_managed_column");
        public MutationQueryBuilder ExceptActivateManagedColumn() =>
            ExceptField("activate_managed_column");
        public MutationQueryBuilder ExceptDeactivateManagedColumn() =>
            ExceptField("deactivate_managed_column");
        public MutationQueryBuilder ExceptDeleteManagedColumn() =>
            ExceptField("delete_managed_column");
        public MutationQueryBuilder ExceptGrantMarketplaceAppDiscount() =>
            ExceptField("grant_marketplace_app_discount");
        public MutationQueryBuilder ExceptDeleteMarketplaceAppDiscount() =>
            ExceptField("delete_marketplace_app_discount");
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
        public MutationQueryBuilder ExceptAddUsersToTeam() =>
            ExceptField("add_users_to_team");
        public MutationQueryBuilder ExceptAddUsersToWorkspace() =>
            ExceptField("add_users_to_workspace");
        public MutationQueryBuilder ExceptArchiveBoard() =>
            ExceptField("archive_board");
        public MutationQueryBuilder ExceptArchiveGroup() =>
            ExceptField("archive_group");
        public MutationQueryBuilder ExceptArchiveItem() =>
            ExceptField("archive_item");
        public MutationQueryBuilder ExceptBatchExtendTrialPeriod() =>
            ExceptField("batch_extend_trial_period");
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
        public MutationQueryBuilder WithComplexity(ComplexityQueryBuilder complexityQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("complexity", alias, complexityQueryBuilder, new GraphQlDirective?[] { include, skip });
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
        public MutationQueryBuilder ExceptDeleteTeamsFromBoard() =>
            ExceptField("delete_teams_from_board");
        public MutationQueryBuilder ExceptDeleteTeamsFromWorkspace() =>
            ExceptField("delete_teams_from_workspace");
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
        public MutationQueryBuilder ExceptIncreaseAppSubscriptionOperations() =>
            ExceptField("increase_app_subscription_operations");
        public MutationQueryBuilder ExceptMoveItemToBoard() =>
            ExceptField("move_item_to_board");
        public MutationQueryBuilder ExceptMoveItemToGroup() =>
            ExceptField("move_item_to_group");
        public MutationQueryBuilder ExceptRemoveMockAppSubscription() =>
            ExceptField("remove_mock_app_subscription");
        public MutationQueryBuilder ExceptRemoveUsersFromTeam() =>
            ExceptField("remove_users_from_team");
        public MutationQueryBuilder ExceptSetMockAppSubscription() =>
            ExceptField("set_mock_app_subscription");
        public MutationQueryBuilder ExceptUpdateAssetsOnItem() =>
            ExceptField("update_assets_on_item");
        public MutationQueryBuilder ExceptUpdateBoard() =>
            ExceptField("update_board");
        public MutationQueryBuilder ExceptUpdateDocBlock() =>
            ExceptField("update_doc_block");
        public MutationQueryBuilder ExceptUpdateFolder() =>
            ExceptField("update_folder");
        public MutationQueryBuilder ExceptUpdateGroup() =>
            ExceptField("update_group");
        public MutationQueryBuilder ExceptUpdateWorkspace() =>
            ExceptField("update_workspace");
        public MutationQueryBuilder ExceptUseTemplate() =>
            ExceptField("use_template");
        public MutationQueryBuilder ExceptConnectProjectToPortfolio() =>
            ExceptField("connect_project_to_portfolio");
        public MutationQueryBuilder ExceptCreateTeam() =>
            ExceptField("create_team");
        public MutationQueryBuilder ExceptActivateUsers() =>
            ExceptField("activate_users");
        public MutationQueryBuilder ExceptDeactivateUsers() =>
            ExceptField("deactivate_users");
        public MutationQueryBuilder ExceptDeleteTeam() =>
            ExceptField("delete_team");
        public MutationQueryBuilder ExceptUpdateUsersRole() =>
            ExceptField("update_users_role");
        public MutationQueryBuilder ExceptAssignTeamOwners() =>
            ExceptField("assign_team_owners");
        public MutationQueryBuilder ExceptRemoveTeamOwners() =>
            ExceptField("remove_team_owners");
        public MutationQueryBuilder ExceptUpdateEmailDomain() =>
            ExceptField("update_email_domain");
        public MutationQueryBuilder ExceptUpdateMultipleUsers() =>
            ExceptField("update_multiple_users");
        public MutationQueryBuilder ExceptInviteUsers() =>
            ExceptField("invite_users");
    }
}

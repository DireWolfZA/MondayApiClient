using System;
using System.Collections.Generic;

namespace MondayApi.Schema {
    public class MutationQueryBuilder : GraphQlQueryBuilder<MutationQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "create_view_table", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(BoardViewQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_view", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(BoardViewQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_view_table", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(BoardViewQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_view", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(BoardViewQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_view", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(BoardViewQueryBuilder) },
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
            new GraphQlFieldMetadata { Name = "update_status_column", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_dropdown_column", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_column", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_column", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_status_column", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_dropdown_column", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_column", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "add_required_column", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(RequiredColumnsQueryBuilder) },
            new GraphQlFieldMetadata { Name = "remove_required_column", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(RequiredColumnsQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_dependency_column", RequiresParameters = true },
            new GraphQlFieldMetadata { Name = "add_content_to_doc_from_markdown", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(DocBlocksFromMarkdownResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_doc", RequiresParameters = true },
            new GraphQlFieldMetadata { Name = "duplicate_doc", RequiresParameters = true },
            new GraphQlFieldMetadata { Name = "import_doc_from_html", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ImportDocFromHtmlResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_article_block", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ArticleBlockQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_doc_name", RequiresParameters = true },
            new GraphQlFieldMetadata { Name = "create_favorite", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(CreateFavoriteResultTypeQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_favorite", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(DeleteFavoriteInputResultTypeQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_favorite_position", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UpdateFavoriteResultTypeQueryBuilder) },
            new GraphQlFieldMetadata { Name = "grant_marketplace_app_discount", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(GrantMarketplaceAppDiscountResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_marketplace_app_discount", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(DeleteMarketplaceAppDiscountResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_app", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(CreateAppResponseQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_app", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AppTypeQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_app_feature", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AppFeatureTypeQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_app_feature", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AppFeatureTypeQueryBuilder) },
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
            new GraphQlFieldMetadata { Name = "change_item_position", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "change_multiple_column_values", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "change_simple_column_value", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "clear_item_updates", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "complexity", IsComplex = true, QueryBuilderType = typeof(ComplexityQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_board", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(BoardQueryBuilder) },
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
            new GraphQlFieldMetadata { Name = "set_board_permission", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(SetBoardPermissionResponseQueryBuilder) },
            new GraphQlFieldMetadata { Name = "set_mock_app_subscription", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AppSubscriptionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_assets_on_item", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_board", RequiresParameters = true },
            new GraphQlFieldMetadata { Name = "update_board_hierarchy", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UpdateBoardHierarchyResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_doc_block", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(DocumentBlockQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_folder", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(FolderQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_group", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(GroupQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_overview_hierarchy", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UpdateOverviewHierarchyQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_workspace", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(WorkspaceQueryBuilder) },
            new GraphQlFieldMetadata { Name = "use_template", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(TemplateQueryBuilder) },
            new GraphQlFieldMetadata { Name = "convert_board_to_project", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ConvertBoardToProjectResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_notification_setting", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(NotificationSettingQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_mute_board_settings", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(BoardMuteSettingsQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_object", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ObjectQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_object", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ObjectQueryBuilder) },
            new GraphQlFieldMetadata { Name = "archive_object", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ObjectQueryBuilder) },
            new GraphQlFieldMetadata { Name = "add_subscribers_to_object", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ObjectQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_object", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ObjectQueryBuilder) },
            new GraphQlFieldMetadata { Name = "publish_object", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ObjectOperationResponseQueryBuilder) },
            new GraphQlFieldMetadata { Name = "unpublish_object", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ObjectOperationResponseQueryBuilder) },
            new GraphQlFieldMetadata { Name = "connect_project_to_portfolio", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ConnectProjectResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_portfolio", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(CreatePortfolioResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_team", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(TeamQueryBuilder) },
            new GraphQlFieldMetadata { Name = "activate_users", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ActivateUsersResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "deactivate_users", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(DeactivateUsersResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_team", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(TeamQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_users_role", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UpdateUsersRoleResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "assign_team_owners", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AssignTeamOwnersResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "remove_team_owners", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(RemoveTeamOwnersResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_email_domain", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UpdateEmailDomainResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_multiple_users", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(UpdateUserAttributesResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "invite_users", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(InviteUsersResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_widget", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(WidgetQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_widget", RequiresParameters = true },
            new GraphQlFieldMetadata { Name = "create_dashboard", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(DashboardQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_dashboard", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(DashboardQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_dashboard", RequiresParameters = true },
            new GraphQlFieldMetadata { Name = "update_form", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ResponseFormQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_form_settings", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ResponseFormQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_form_question", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(FormQuestionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_form_question", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(FormQuestionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "delete_question", RequiresParameters = true },
            new GraphQlFieldMetadata { Name = "activate_form", RequiresParameters = true },
            new GraphQlFieldMetadata { Name = "deactivate_form", RequiresParameters = true },
            new GraphQlFieldMetadata { Name = "shorten_form_url", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(FormShortenedLinkQueryBuilder) },
            new GraphQlFieldMetadata { Name = "create_form_tag", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(FormTagQueryBuilder) },
            new GraphQlFieldMetadata { Name = "update_form_tag", RequiresParameters = true },
            new GraphQlFieldMetadata { Name = "delete_form_tag", RequiresParameters = true },
            new GraphQlFieldMetadata { Name = "create_form", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(DehydratedFormResponseQueryBuilder) },
            new GraphQlFieldMetadata { Name = "set_form_password", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ResponseFormQueryBuilder) }
        };

        public MutationQueryBuilder(string? operationName = null) : base("mutation", operationName) { }
        protected override string TypeName => "Mutation";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public MutationQueryBuilder WithParameter<T>(GraphQlQueryParameter<T> parameter) =>
            WithParameterInternal(parameter);
        public MutationQueryBuilder WithCreateViewTable(BoardViewQueryBuilder boardViewQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string?>? name = null, QueryBuilderParameter<string?>? filterUserID = null, QueryBuilderParameter<string?>? filterTeamID = null, QueryBuilderParameter<ItemsQueryGroup?>? filter = null, QueryBuilderParameter<IEnumerable<ItemsQueryOrderBy>>? sort = null, QueryBuilderParameter<IEnumerable<string>>? tags = null, QueryBuilderParameter<TableViewSettingsInput?>? settings = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            if (name != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name });
            if (filterUserID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "filter_user_id", ArgumentValue = filterUserID });
            if (filterTeamID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "filter_team_id", ArgumentValue = filterTeamID });
            if (filter != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "filter", ArgumentValue = filter });
            if (sort != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "sort", ArgumentValue = sort });
            if (tags != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "tags", ArgumentValue = tags });
            if (settings != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "settings", ArgumentValue = settings });
            return WithObjectField("create_view_table", alias, boardViewQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateViewTable() =>
            ExceptField("create_view_table");
        public MutationQueryBuilder WithCreateView(BoardViewQueryBuilder boardViewQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<ViewKind> type, QueryBuilderParameter<string?>? name = null, QueryBuilderParameter<string?>? filterUserID = null, QueryBuilderParameter<string?>? filterTeamID = null, QueryBuilderParameter<ItemsQueryGroup?>? filter = null, QueryBuilderParameter<IEnumerable<ItemsQueryOrderBy>>? sort = null, QueryBuilderParameter<IEnumerable<string>>? tags = null, QueryBuilderParameter<object?>? settings = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "type", ArgumentValue = type }
            };
            if (name != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name });
            if (filterUserID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "filter_user_id", ArgumentValue = filterUserID });
            if (filterTeamID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "filter_team_id", ArgumentValue = filterTeamID });
            if (filter != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "filter", ArgumentValue = filter });
            if (sort != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "sort", ArgumentValue = sort });
            if (tags != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "tags", ArgumentValue = tags });
            if (settings != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "settings", ArgumentValue = settings });
            return WithObjectField("create_view", alias, boardViewQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateView() =>
            ExceptField("create_view");
        public MutationQueryBuilder WithUpdateViewTable(BoardViewQueryBuilder boardViewQueryBuilder, QueryBuilderParameter<string> viewID, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string?>? name = null, QueryBuilderParameter<string?>? filterUserID = null, QueryBuilderParameter<string?>? filterTeamID = null, QueryBuilderParameter<ItemsQueryGroup?>? filter = null, QueryBuilderParameter<IEnumerable<ItemsQueryOrderBy>>? sort = null, QueryBuilderParameter<IEnumerable<string>>? tags = null, QueryBuilderParameter<TableViewSettingsInput?>? settings = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "view_id", ArgumentValue = viewID },
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            if (name != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name });
            if (filterUserID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "filter_user_id", ArgumentValue = filterUserID });
            if (filterTeamID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "filter_team_id", ArgumentValue = filterTeamID });
            if (filter != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "filter", ArgumentValue = filter });
            if (sort != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "sort", ArgumentValue = sort });
            if (tags != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "tags", ArgumentValue = tags });
            if (settings != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "settings", ArgumentValue = settings });
            return WithObjectField("update_view_table", alias, boardViewQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateViewTable() =>
            ExceptField("update_view_table");
        public MutationQueryBuilder WithUpdateView(BoardViewQueryBuilder boardViewQueryBuilder, QueryBuilderParameter<string> viewID, QueryBuilderParameter<string> boardID, QueryBuilderParameter<ViewKind> type, QueryBuilderParameter<string?>? name = null, QueryBuilderParameter<string?>? filterUserID = null, QueryBuilderParameter<string?>? filterTeamID = null, QueryBuilderParameter<ItemsQueryGroup?>? filter = null, QueryBuilderParameter<IEnumerable<ItemsQueryOrderBy>>? sort = null, QueryBuilderParameter<IEnumerable<string>>? tags = null, QueryBuilderParameter<object?>? settings = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (name != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name });
            if (filterUserID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "filter_user_id", ArgumentValue = filterUserID });
            if (filterTeamID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "filter_team_id", ArgumentValue = filterTeamID });
            if (filter != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "filter", ArgumentValue = filter });
            if (sort != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "sort", ArgumentValue = sort });
            if (tags != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "tags", ArgumentValue = tags });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "view_id", ArgumentValue = viewID });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "type", ArgumentValue = type });
            if (settings != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "settings", ArgumentValue = settings });
            return WithObjectField("update_view", alias, boardViewQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateView() =>
            ExceptField("update_view");
        public MutationQueryBuilder WithDeleteView(BoardViewQueryBuilder boardViewQueryBuilder, QueryBuilderParameter<string> viewID, QueryBuilderParameter<string> boardID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "view_id", ArgumentValue = viewID },
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            return WithObjectField("delete_view", alias, boardViewQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteView() =>
            ExceptField("delete_view");
        public MutationQueryBuilder WithLikeUpdate(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<string> updateID, QueryBuilderParameter<string?>? reactionType = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "update_id", ArgumentValue = updateID }
            };
            if (reactionType != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "reaction_type", ArgumentValue = reactionType });
            return WithObjectField("like_update", alias, updateQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptLikeUpdate() =>
            ExceptField("like_update");
        public MutationQueryBuilder WithUnlikeUpdate(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<string> updateID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "update_id", ArgumentValue = updateID }
            };
            return WithObjectField("unlike_update", alias, updateQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUnlikeUpdate() =>
            ExceptField("unlike_update");
        public MutationQueryBuilder WithDeleteUpdate(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<string> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("delete_update", alias, updateQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteUpdate() =>
            ExceptField("delete_update");
        public MutationQueryBuilder WithEditUpdate(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<string> id, QueryBuilderParameter<string> body, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id },
                new QueryBuilderArgumentInfo { ArgumentName = "body", ArgumentValue = body }
            };
            return WithObjectField("edit_update", alias, updateQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptEditUpdate() =>
            ExceptField("edit_update");
        public MutationQueryBuilder WithPinToTop(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<string> id, QueryBuilderParameter<string?>? itemID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });
            return WithObjectField("pin_to_top", alias, updateQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptPinToTop() =>
            ExceptField("pin_to_top");
        public MutationQueryBuilder WithUnpinFromTop(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<string> id, QueryBuilderParameter<string?>? itemID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });
            return WithObjectField("unpin_from_top", alias, updateQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUnpinFromTop() =>
            ExceptField("unpin_from_top");
        public MutationQueryBuilder WithCreateUpdate(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<string> body, QueryBuilderParameter<string?>? originalCreationDate = null, QueryBuilderParameter<IEnumerable<UpdateMention?>>? mentionsList = null, QueryBuilderParameter<string?>? itemID = null, QueryBuilderParameter<string?>? parentID = null, QueryBuilderParameter<bool?>? useAppInfo = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "body", ArgumentValue = body }
            };
            if (originalCreationDate != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "original_creation_date", ArgumentValue = originalCreationDate });
            if (mentionsList != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "mentions_list", ArgumentValue = mentionsList });
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });
            if (parentID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "parent_id", ArgumentValue = parentID });
            if (useAppInfo != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "use_app_info", ArgumentValue = useAppInfo });
            return WithObjectField("create_update", alias, updateQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateUpdate() =>
            ExceptField("create_update");
        public MutationQueryBuilder WithCreateTimelineItem(TimelineItemQueryBuilder timelineItemQueryBuilder, QueryBuilderParameter<string> itemID, QueryBuilderParameter<string> title, QueryBuilderParameter<DateTimeOffset> timestamp, QueryBuilderParameter<string> customActivityID, QueryBuilderParameter<int?>? userID = null, QueryBuilderParameter<string?>? summary = null, QueryBuilderParameter<string?>? content = null, QueryBuilderParameter<string?>? location = null, QueryBuilderParameter<string?>? phone = null, QueryBuilderParameter<string?>? url = null, QueryBuilderParameter<TimelineItemTimeRange?>? timeRange = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID }
            };
            if (userID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "user_id", ArgumentValue = userID });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "title", ArgumentValue = title });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "timestamp", ArgumentValue = timestamp });
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
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "custom_activity_id", ArgumentValue = customActivityID });
            return WithObjectField("create_timeline_item", alias, timelineItemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateTimelineItem() =>
            ExceptField("create_timeline_item");
        public MutationQueryBuilder WithDeleteTimelineItem(TimelineItemQueryBuilder timelineItemQueryBuilder, QueryBuilderParameter<string> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("delete_timeline_item", alias, timelineItemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteTimelineItem() =>
            ExceptField("delete_timeline_item");
        public MutationQueryBuilder WithCreateCustomActivity(CustomActivityQueryBuilder customActivityQueryBuilder, QueryBuilderParameter<string> name, QueryBuilderParameter<CustomActivityIcon> iconID, QueryBuilderParameter<CustomActivityColor> color, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name },
                new QueryBuilderArgumentInfo { ArgumentName = "icon_id", ArgumentValue = iconID },
                new QueryBuilderArgumentInfo { ArgumentName = "color", ArgumentValue = color }
            };
            return WithObjectField("create_custom_activity", alias, customActivityQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateCustomActivity() =>
            ExceptField("create_custom_activity");
        public MutationQueryBuilder WithDeleteCustomActivity(CustomActivityQueryBuilder customActivityQueryBuilder, QueryBuilderParameter<string> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("delete_custom_activity", alias, customActivityQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteCustomActivity() =>
            ExceptField("delete_custom_activity");
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
        public MutationQueryBuilder ExceptCreateDropdownManagedColumn() =>
            ExceptField("create_dropdown_managed_column");
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
        public MutationQueryBuilder ExceptCreateStatusManagedColumn() =>
            ExceptField("create_status_managed_column");
        public MutationQueryBuilder WithUpdateDropdownManagedColumn(DropdownManagedColumnQueryBuilder dropdownManagedColumnQueryBuilder, QueryBuilderParameter<string> id, QueryBuilderParameter<int> revision, QueryBuilderParameter<string?>? title = null, QueryBuilderParameter<string?>? description = null, QueryBuilderParameter<UpdateDropdownColumnSettingsInput?>? settings = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            if (title != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "title", ArgumentValue = title });
            if (description != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "description", ArgumentValue = description });
            if (settings != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "settings", ArgumentValue = settings });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "revision", ArgumentValue = revision });
            return WithObjectField("update_dropdown_managed_column", alias, dropdownManagedColumnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateDropdownManagedColumn() =>
            ExceptField("update_dropdown_managed_column");
        public MutationQueryBuilder WithUpdateStatusManagedColumn(StatusManagedColumnQueryBuilder statusManagedColumnQueryBuilder, QueryBuilderParameter<string> id, QueryBuilderParameter<int> revision, QueryBuilderParameter<string?>? title = null, QueryBuilderParameter<string?>? description = null, QueryBuilderParameter<UpdateStatusColumnSettingsInput?>? settings = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            if (title != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "title", ArgumentValue = title });
            if (description != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "description", ArgumentValue = description });
            if (settings != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "settings", ArgumentValue = settings });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "revision", ArgumentValue = revision });
            return WithObjectField("update_status_managed_column", alias, statusManagedColumnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateStatusManagedColumn() =>
            ExceptField("update_status_managed_column");
        public MutationQueryBuilder WithActivateManagedColumn(ManagedColumnQueryBuilder managedColumnQueryBuilder, QueryBuilderParameter<string> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("activate_managed_column", alias, managedColumnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptActivateManagedColumn() =>
            ExceptField("activate_managed_column");
        public MutationQueryBuilder WithDeactivateManagedColumn(ManagedColumnQueryBuilder managedColumnQueryBuilder, QueryBuilderParameter<string> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("deactivate_managed_column", alias, managedColumnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeactivateManagedColumn() =>
            ExceptField("deactivate_managed_column");
        public MutationQueryBuilder WithDeleteManagedColumn(ManagedColumnQueryBuilder managedColumnQueryBuilder, QueryBuilderParameter<string> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("delete_managed_column", alias, managedColumnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteManagedColumn() =>
            ExceptField("delete_managed_column");
        public MutationQueryBuilder WithUpdateStatusColumn(ColumnQueryBuilder columnQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> id, QueryBuilderParameter<string> revision, QueryBuilderParameter<string?>? title = null, QueryBuilderParameter<string?>? description = null, QueryBuilderParameter<StatusColumnCapabilitiesInput?>? capabilities = null, QueryBuilderParameter<UpdateStatusColumnSettingsInput?>? settings = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            if (title != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "title", ArgumentValue = title });
            if (description != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "description", ArgumentValue = description });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "revision", ArgumentValue = revision });
            if (capabilities != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "capabilities", ArgumentValue = capabilities });
            if (settings != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "settings", ArgumentValue = settings });
            return WithObjectField("update_status_column", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateStatusColumn() =>
            ExceptField("update_status_column");
        public MutationQueryBuilder WithUpdateDropdownColumn(ColumnQueryBuilder columnQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> id, QueryBuilderParameter<string> revision, QueryBuilderParameter<string?>? title = null, QueryBuilderParameter<string?>? description = null, QueryBuilderParameter<UpdateDropdownColumnSettingsInput?>? settings = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            if (title != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "title", ArgumentValue = title });
            if (description != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "description", ArgumentValue = description });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "revision", ArgumentValue = revision });
            if (settings != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "settings", ArgumentValue = settings });
            return WithObjectField("update_dropdown_column", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateDropdownColumn() =>
            ExceptField("update_dropdown_column");
        public MutationQueryBuilder WithUpdateColumn(ColumnQueryBuilder columnQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> id, QueryBuilderParameter<string> revision, QueryBuilderParameter<ColumnType> columnType, QueryBuilderParameter<string?>? title = null, QueryBuilderParameter<string?>? description = null, QueryBuilderParameter<ColumnCapabilitiesInput?>? capabilities = null, QueryBuilderParameter<object?>? settings = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            if (title != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "title", ArgumentValue = title });
            if (description != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "description", ArgumentValue = description });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "revision", ArgumentValue = revision });
            if (capabilities != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "capabilities", ArgumentValue = capabilities });
            if (settings != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "settings", ArgumentValue = settings });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "column_type", ArgumentValue = columnType });
            return WithObjectField("update_column", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateColumn() =>
            ExceptField("update_column");
        public MutationQueryBuilder WithDeleteColumn(ColumnQueryBuilder columnQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> columnID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "column_id", ArgumentValue = columnID }
            };
            return WithObjectField("delete_column", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteColumn() =>
            ExceptField("delete_column");
        public MutationQueryBuilder WithCreateStatusColumn(ColumnQueryBuilder columnQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> title, QueryBuilderParameter<string?>? id = null, QueryBuilderParameter<string?>? description = null, QueryBuilderParameter<string?>? afterColumnID = null, QueryBuilderParameter<StatusColumnCapabilitiesInput?>? capabilities = null, QueryBuilderParameter<CreateStatusColumnSettingsInput?>? defaults = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            if (id != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "title", ArgumentValue = title });
            if (description != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "description", ArgumentValue = description });
            if (afterColumnID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "after_column_id", ArgumentValue = afterColumnID });
            if (capabilities != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "capabilities", ArgumentValue = capabilities });
            if (defaults != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "defaults", ArgumentValue = defaults });
            return WithObjectField("create_status_column", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateStatusColumn() =>
            ExceptField("create_status_column");
        public MutationQueryBuilder WithCreateDropdownColumn(ColumnQueryBuilder columnQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> title, QueryBuilderParameter<string?>? id = null, QueryBuilderParameter<string?>? description = null, QueryBuilderParameter<string?>? afterColumnID = null, QueryBuilderParameter<CreateDropdownColumnSettingsInput?>? defaults = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            if (id != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "title", ArgumentValue = title });
            if (description != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "description", ArgumentValue = description });
            if (afterColumnID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "after_column_id", ArgumentValue = afterColumnID });
            if (defaults != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "defaults", ArgumentValue = defaults });
            return WithObjectField("create_dropdown_column", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateDropdownColumn() =>
            ExceptField("create_dropdown_column");
        public MutationQueryBuilder WithCreateColumn(ColumnQueryBuilder columnQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> title, QueryBuilderParameter<ColumnType> columnType, QueryBuilderParameter<string?>? id = null, QueryBuilderParameter<string?>? description = null, QueryBuilderParameter<string?>? afterColumnID = null, QueryBuilderParameter<ColumnCapabilitiesInput?>? capabilities = null, QueryBuilderParameter<object?>? defaults = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            if (id != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "title", ArgumentValue = title });
            if (description != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "description", ArgumentValue = description });
            if (afterColumnID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "after_column_id", ArgumentValue = afterColumnID });
            if (capabilities != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "capabilities", ArgumentValue = capabilities });
            if (defaults != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "defaults", ArgumentValue = defaults });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "column_type", ArgumentValue = columnType });
            return WithObjectField("create_column", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateColumn() =>
            ExceptField("create_column");
        public MutationQueryBuilder WithAddRequiredColumn(RequiredColumnsQueryBuilder requiredColumnsQueryBuilder, QueryBuilderParameter<string> id, QueryBuilderParameter<string> columnID, QueryBuilderParameter<ValidationsEntityType?>? type = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id },
                new QueryBuilderArgumentInfo { ArgumentName = "column_id", ArgumentValue = columnID }
            };
            if (type != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "type", ArgumentValue = type });
            return WithObjectField("add_required_column", alias, requiredColumnsQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptAddRequiredColumn() =>
            ExceptField("add_required_column");
        public MutationQueryBuilder WithRemoveRequiredColumn(RequiredColumnsQueryBuilder requiredColumnsQueryBuilder, QueryBuilderParameter<string> id, QueryBuilderParameter<string> columnID, QueryBuilderParameter<ValidationsEntityType?>? type = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id },
                new QueryBuilderArgumentInfo { ArgumentName = "column_id", ArgumentValue = columnID }
            };
            if (type != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "type", ArgumentValue = type });
            return WithObjectField("remove_required_column", alias, requiredColumnsQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptRemoveRequiredColumn() =>
            ExceptField("remove_required_column");
        public MutationQueryBuilder WithUpdateDependencyColumn(QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> pulseID, QueryBuilderParameter<DependencyValueInput> value, QueryBuilderParameter<string> columnID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "boardId", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "pulseId", ArgumentValue = pulseID },
                new QueryBuilderArgumentInfo { ArgumentName = "value", ArgumentValue = value },
                new QueryBuilderArgumentInfo { ArgumentName = "columnId", ArgumentValue = columnID }
            };
            return WithScalarField("update_dependency_column", alias, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateDependencyColumn() =>
            ExceptField("update_dependency_column");
        public MutationQueryBuilder WithAddContentToDocFromMarkdown(DocBlocksFromMarkdownResultQueryBuilder docBlocksFromMarkdownResultQueryBuilder, QueryBuilderParameter<string> docID, QueryBuilderParameter<string> markdown, QueryBuilderParameter<string?>? afterBlockID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "docId", ArgumentValue = docID },
                new QueryBuilderArgumentInfo { ArgumentName = "markdown", ArgumentValue = markdown }
            };
            if (afterBlockID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "afterBlockId", ArgumentValue = afterBlockID });
            return WithObjectField("add_content_to_doc_from_markdown", alias, docBlocksFromMarkdownResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptAddContentToDocFromMarkdown() =>
            ExceptField("add_content_to_doc_from_markdown");
        public MutationQueryBuilder WithDeleteDoc(QueryBuilderParameter<string> docID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "docId", ArgumentValue = docID }
            };
            return WithScalarField("delete_doc", alias, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteDoc() =>
            ExceptField("delete_doc");
        public MutationQueryBuilder WithDuplicateDoc(QueryBuilderParameter<string> docID, QueryBuilderParameter<DuplicateType?>? duplicateType = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "docId", ArgumentValue = docID }
            };
            if (duplicateType != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "duplicateType", ArgumentValue = duplicateType });
            return WithScalarField("duplicate_doc", alias, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDuplicateDoc() =>
            ExceptField("duplicate_doc");
        public MutationQueryBuilder WithImportDocFromHtml(ImportDocFromHtmlResultQueryBuilder importDocFromHtmlResultQueryBuilder, QueryBuilderParameter<string> html, QueryBuilderParameter<string> workspaceID, QueryBuilderParameter<DocKind?>? kind = null, QueryBuilderParameter<string?>? folderID = null, QueryBuilderParameter<string?>? title = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "html", ArgumentValue = html },
                new QueryBuilderArgumentInfo { ArgumentName = "workspaceId", ArgumentValue = workspaceID }
            };
            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });
            if (folderID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "folderId", ArgumentValue = folderID });
            if (title != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "title", ArgumentValue = title });
            return WithObjectField("import_doc_from_html", alias, importDocFromHtmlResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptImportDocFromHtml() =>
            ExceptField("import_doc_from_html");
        public MutationQueryBuilder WithUpdateArticleBlock(ArticleBlockQueryBuilder articleBlockQueryBuilder, QueryBuilderParameter<string> blockID, QueryBuilderParameter<object> content, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "block_id", ArgumentValue = blockID },
                new QueryBuilderArgumentInfo { ArgumentName = "content", ArgumentValue = content }
            };
            return WithObjectField("update_article_block", alias, articleBlockQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateArticleBlock() =>
            ExceptField("update_article_block");
        public MutationQueryBuilder WithUpdateDocName(QueryBuilderParameter<string> docID, QueryBuilderParameter<string> name, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "docId", ArgumentValue = docID },
                new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name }
            };
            return WithScalarField("update_doc_name", alias, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateDocName() =>
            ExceptField("update_doc_name");
        public MutationQueryBuilder WithCreateFavorite(CreateFavoriteResultTypeQueryBuilder createFavoriteResultTypeQueryBuilder, QueryBuilderParameter<CreateFavoriteInput> input, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "input", ArgumentValue = input }
            };
            return WithObjectField("create_favorite", alias, createFavoriteResultTypeQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateFavorite() =>
            ExceptField("create_favorite");
        public MutationQueryBuilder WithDeleteFavorite(DeleteFavoriteInputResultTypeQueryBuilder deleteFavoriteInputResultTypeQueryBuilder, QueryBuilderParameter<DeleteFavoriteInput> input, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "input", ArgumentValue = input }
            };
            return WithObjectField("delete_favorite", alias, deleteFavoriteInputResultTypeQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteFavorite() =>
            ExceptField("delete_favorite");
        public MutationQueryBuilder WithUpdateFavoritePosition(UpdateFavoriteResultTypeQueryBuilder updateFavoriteResultTypeQueryBuilder, QueryBuilderParameter<UpdateObjectHierarchyPositionInput> input, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "input", ArgumentValue = input }
            };
            return WithObjectField("update_favorite_position", alias, updateFavoriteResultTypeQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateFavoritePosition() =>
            ExceptField("update_favorite_position");
        public MutationQueryBuilder WithGrantMarketplaceAppDiscount(GrantMarketplaceAppDiscountResultQueryBuilder grantMarketplaceAppDiscountResultQueryBuilder, QueryBuilderParameter<string> appID, QueryBuilderParameter<string> accountSlug, QueryBuilderParameter<GrantMarketplaceAppDiscountData> data, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "app_id", ArgumentValue = appID },
                new QueryBuilderArgumentInfo { ArgumentName = "account_slug", ArgumentValue = accountSlug },
                new QueryBuilderArgumentInfo { ArgumentName = "data", ArgumentValue = data }
            };
            return WithObjectField("grant_marketplace_app_discount", alias, grantMarketplaceAppDiscountResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptGrantMarketplaceAppDiscount() =>
            ExceptField("grant_marketplace_app_discount");
        public MutationQueryBuilder WithDeleteMarketplaceAppDiscount(DeleteMarketplaceAppDiscountResultQueryBuilder deleteMarketplaceAppDiscountResultQueryBuilder, QueryBuilderParameter<string> appID, QueryBuilderParameter<string> accountSlug, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "app_id", ArgumentValue = appID },
                new QueryBuilderArgumentInfo { ArgumentName = "account_slug", ArgumentValue = accountSlug }
            };
            return WithObjectField("delete_marketplace_app_discount", alias, deleteMarketplaceAppDiscountResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteMarketplaceAppDiscount() =>
            ExceptField("delete_marketplace_app_discount");
        public MutationQueryBuilder WithCreateApp(CreateAppResponseQueryBuilder createAppResponseQueryBuilder, QueryBuilderParameter<CreateAppInput> input, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "input", ArgumentValue = input }
            };
            return WithObjectField("create_app", alias, createAppResponseQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateApp() =>
            ExceptField("create_app");
        public MutationQueryBuilder WithUpdateApp(AppTypeQueryBuilder appTypeQueryBuilder, QueryBuilderParameter<string> id, QueryBuilderParameter<UpdateAppInput> input, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id },
                new QueryBuilderArgumentInfo { ArgumentName = "input", ArgumentValue = input }
            };
            return WithObjectField("update_app", alias, appTypeQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateApp() =>
            ExceptField("update_app");
        public MutationQueryBuilder WithUpdateAppFeature(AppFeatureTypeQueryBuilder appFeatureTypeQueryBuilder, QueryBuilderParameter<string> id, QueryBuilderParameter<UpdateAppFeatureInput> input, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id },
                new QueryBuilderArgumentInfo { ArgumentName = "input", ArgumentValue = input }
            };
            return WithObjectField("update_app_feature", alias, appFeatureTypeQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateAppFeature() =>
            ExceptField("update_app_feature");
        public MutationQueryBuilder WithCreateAppFeature(AppFeatureTypeQueryBuilder appFeatureTypeQueryBuilder, QueryBuilderParameter<string> slug, QueryBuilderParameter<string> appID, QueryBuilderParameter<AppFeatureTypeE> type, QueryBuilderParameter<string?>? name = null, QueryBuilderParameter<string?>? appVersionID = null, QueryBuilderParameter<object?>? data = null, QueryBuilderParameter<AppFeatureReleaseInput?>? deployment = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (name != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "slug", ArgumentValue = slug });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "app_id", ArgumentValue = appID });
            if (appVersionID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "app_version_id", ArgumentValue = appVersionID });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "type", ArgumentValue = type });
            if (data != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "data", ArgumentValue = data });
            if (deployment != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "deployment", ArgumentValue = deployment });
            return WithObjectField("create_app_feature", alias, appFeatureTypeQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateAppFeature() =>
            ExceptField("create_app_feature");
        public MutationQueryBuilder WithAddFileToColumn(AssetQueryBuilder assetQueryBuilder, QueryBuilderParameter<string> columnID, QueryBuilderParameter<object> file, QueryBuilderParameter<string> itemID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "column_id", ArgumentValue = columnID },
                new QueryBuilderArgumentInfo { ArgumentName = "file", ArgumentValue = file },
                new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID }
            };
            return WithObjectField("add_file_to_column", alias, assetQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptAddFileToColumn() =>
            ExceptField("add_file_to_column");
        public MutationQueryBuilder WithAddFileToUpdate(AssetQueryBuilder assetQueryBuilder, QueryBuilderParameter<object> file, QueryBuilderParameter<string> updateID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "file", ArgumentValue = file },
                new QueryBuilderArgumentInfo { ArgumentName = "update_id", ArgumentValue = updateID }
            };
            return WithObjectField("add_file_to_update", alias, assetQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptAddFileToUpdate() =>
            ExceptField("add_file_to_update");
        public MutationQueryBuilder WithAddTeamsToBoard(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<IEnumerable<string>> teamIDs, QueryBuilderParameter<BoardSubscriberKind?>? kind = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "team_ids", ArgumentValue = teamIDs });
            return WithObjectField("add_teams_to_board", alias, teamQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptAddTeamsToBoard() =>
            ExceptField("add_teams_to_board");
        public MutationQueryBuilder WithAddTeamsToWorkspace(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<IEnumerable<string>> teamIDs, QueryBuilderParameter<string> workspaceID, QueryBuilderParameter<WorkspaceSubscriberKind?>? kind = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "team_ids", ArgumentValue = teamIDs });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID });
            return WithObjectField("add_teams_to_workspace", alias, teamQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptAddTeamsToWorkspace() =>
            ExceptField("add_teams_to_workspace");
        public MutationQueryBuilder WithAddUsersToBoard(UserQueryBuilder userQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<IEnumerable<string>> userIDs, QueryBuilderParameter<BoardSubscriberKind?>? kind = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs });
            return WithObjectField("add_users_to_board", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptAddUsersToBoard() =>
            ExceptField("add_users_to_board");
        public MutationQueryBuilder WithAddUsersToTeam(ChangeTeamMembershipsResultQueryBuilder changeTeamMembershipsResultQueryBuilder, QueryBuilderParameter<string> teamID, QueryBuilderParameter<IEnumerable<string>> userIDs, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "team_id", ArgumentValue = teamID },
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs }
            };
            return WithObjectField("add_users_to_team", alias, changeTeamMembershipsResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptAddUsersToTeam() =>
            ExceptField("add_users_to_team");
        public MutationQueryBuilder WithAddUsersToWorkspace(UserQueryBuilder userQueryBuilder, QueryBuilderParameter<IEnumerable<string>> userIDs, QueryBuilderParameter<string> workspaceID, QueryBuilderParameter<WorkspaceSubscriberKind?>? kind = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID });
            return WithObjectField("add_users_to_workspace", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptAddUsersToWorkspace() =>
            ExceptField("add_users_to_workspace");
        public MutationQueryBuilder WithArchiveBoard(BoardQueryBuilder boardQueryBuilder, QueryBuilderParameter<string> boardID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            return WithObjectField("archive_board", alias, boardQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptArchiveBoard() =>
            ExceptField("archive_board");
        public MutationQueryBuilder WithArchiveGroup(GroupQueryBuilder groupQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> groupID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "group_id", ArgumentValue = groupID }
            };
            return WithObjectField("archive_group", alias, groupQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptArchiveGroup() =>
            ExceptField("archive_group");
        public MutationQueryBuilder WithArchiveItem(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string?>? itemID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });
            return WithObjectField("archive_item", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptArchiveItem() =>
            ExceptField("archive_item");
        public MutationQueryBuilder WithBatchExtendTrialPeriod(BatchExtendTrialPeriodQueryBuilder batchExtendTrialPeriodQueryBuilder, QueryBuilderParameter<IEnumerable<string>> accountSlugs, QueryBuilderParameter<string> appID, QueryBuilderParameter<int> durationInDays, QueryBuilderParameter<string> planID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "account_slugs", ArgumentValue = accountSlugs },
                new QueryBuilderArgumentInfo { ArgumentName = "app_id", ArgumentValue = appID },
                new QueryBuilderArgumentInfo { ArgumentName = "duration_in_days", ArgumentValue = durationInDays },
                new QueryBuilderArgumentInfo { ArgumentName = "plan_id", ArgumentValue = planID }
            };
            return WithObjectField("batch_extend_trial_period", alias, batchExtendTrialPeriodQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptBatchExtendTrialPeriod() =>
            ExceptField("batch_extend_trial_period");
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
        public MutationQueryBuilder ExceptChangeColumnMetadata() =>
            ExceptField("change_column_metadata");
        public MutationQueryBuilder WithChangeColumnTitle(ColumnQueryBuilder columnQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> columnID, QueryBuilderParameter<string> title, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "column_id", ArgumentValue = columnID },
                new QueryBuilderArgumentInfo { ArgumentName = "title", ArgumentValue = title }
            };
            return WithObjectField("change_column_title", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptChangeColumnTitle() =>
            ExceptField("change_column_title");
        public MutationQueryBuilder WithChangeColumnValue(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> columnID, QueryBuilderParameter<string> value, QueryBuilderParameter<bool?>? createLabelsIfMissing = null, QueryBuilderParameter<string?>? itemID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "column_id", ArgumentValue = columnID }
            };
            if (createLabelsIfMissing != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "create_labels_if_missing", ArgumentValue = createLabelsIfMissing });
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "value", ArgumentValue = value });
            return WithObjectField("change_column_value", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptChangeColumnValue() =>
            ExceptField("change_column_value");
        public MutationQueryBuilder WithChangeItemPosition(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> itemID, QueryBuilderParameter<string?>? groupID = null, QueryBuilderParameter<bool?>? groupTop = null, QueryBuilderParameter<PositionRelative?>? positionRelativeMethod = null, QueryBuilderParameter<string?>? relativeTo = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (groupID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "group_id", ArgumentValue = groupID });
            if (groupTop != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "group_top", ArgumentValue = groupTop });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });
            if (positionRelativeMethod != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "position_relative_method", ArgumentValue = positionRelativeMethod });
            if (relativeTo != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "relative_to", ArgumentValue = relativeTo });
            return WithObjectField("change_item_position", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptChangeItemPosition() =>
            ExceptField("change_item_position");
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
        public MutationQueryBuilder ExceptChangeMultipleColumnValues() =>
            ExceptField("change_multiple_column_values");
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
        public MutationQueryBuilder ExceptChangeSimpleColumnValue() =>
            ExceptField("change_simple_column_value");
        public MutationQueryBuilder WithClearItemUpdates(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> itemID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID }
            };
            return WithObjectField("clear_item_updates", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptClearItemUpdates() =>
            ExceptField("clear_item_updates");
        public MutationQueryBuilder WithComplexity(ComplexityQueryBuilder complexityQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("complexity", alias, complexityQueryBuilder, new GraphQlDirective?[] { include, skip });
        public MutationQueryBuilder ExceptComplexity() =>
            ExceptField("complexity");
        public MutationQueryBuilder WithCreateBoard(BoardQueryBuilder boardQueryBuilder, QueryBuilderParameter<BoardKind> boardKind, QueryBuilderParameter<string> boardName, QueryBuilderParameter<IEnumerable<string>>? boardOwnerIDs = null, QueryBuilderParameter<IEnumerable<string>>? boardOwnerTeamIDs = null, QueryBuilderParameter<IEnumerable<string>>? boardSubscriberIDs = null, QueryBuilderParameter<IEnumerable<string>>? boardSubscriberTeamsIDs = null, QueryBuilderParameter<string?>? description = null, QueryBuilderParameter<bool?>? empty = null, QueryBuilderParameter<string?>? folderID = null, QueryBuilderParameter<ItemNicknameInput?>? itemNickname = null, QueryBuilderParameter<string?>? templateID = null, QueryBuilderParameter<string?>? workspaceID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
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
            if (itemNickname != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_nickname", ArgumentValue = itemNickname });
            if (templateID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "template_id", ArgumentValue = templateID });
            if (workspaceID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID });
            return WithObjectField("create_board", alias, boardQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateBoard() =>
            ExceptField("create_board");
        public MutationQueryBuilder WithCreateDoc(DocumentQueryBuilder documentQueryBuilder, QueryBuilderParameter<CreateDocInput> location, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "location", ArgumentValue = location }
            };
            return WithObjectField("create_doc", alias, documentQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateDoc() =>
            ExceptField("create_doc");
        public MutationQueryBuilder WithCreateDocBlock(DocumentBlockQueryBuilder documentBlockQueryBuilder, QueryBuilderParameter<object> content, QueryBuilderParameter<string> docID, QueryBuilderParameter<DocBlockContentType> type, QueryBuilderParameter<string?>? afterBlockID = null, QueryBuilderParameter<string?>? parentBlockID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (afterBlockID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "after_block_id", ArgumentValue = afterBlockID });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "content", ArgumentValue = content });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "doc_id", ArgumentValue = docID });
            if (parentBlockID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "parent_block_id", ArgumentValue = parentBlockID });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "type", ArgumentValue = type });
            return WithObjectField("create_doc_block", alias, documentBlockQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateDocBlock() =>
            ExceptField("create_doc_block");
        public MutationQueryBuilder WithCreateFolder(FolderQueryBuilder folderQueryBuilder, QueryBuilderParameter<string> name, QueryBuilderParameter<FolderColor?>? color = null, QueryBuilderParameter<FolderCustomIcon?>? customIcon = null, QueryBuilderParameter<FolderFontWeight?>? fontWeight = null, QueryBuilderParameter<string?>? parentFolderID = null, QueryBuilderParameter<string?>? workspaceID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (color != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "color", ArgumentValue = color });
            if (customIcon != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "custom_icon", ArgumentValue = customIcon });
            if (fontWeight != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "font_weight", ArgumentValue = fontWeight });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name });
            if (parentFolderID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "parent_folder_id", ArgumentValue = parentFolderID });
            if (workspaceID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID });
            return WithObjectField("create_folder", alias, folderQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateFolder() =>
            ExceptField("create_folder");
        public MutationQueryBuilder WithCreateGroup(GroupQueryBuilder groupQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> groupName, QueryBuilderParameter<string?>? groupColor = null, QueryBuilderParameter<string?>? position = null, QueryBuilderParameter<PositionRelative?>? positionRelativeMethod = null, QueryBuilderParameter<string?>? relativeTo = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            if (groupColor != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "group_color", ArgumentValue = groupColor });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "group_name", ArgumentValue = groupName });
            if (position != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "position", ArgumentValue = position });
            if (positionRelativeMethod != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "position_relative_method", ArgumentValue = positionRelativeMethod });
            if (relativeTo != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "relative_to", ArgumentValue = relativeTo });
            return WithObjectField("create_group", alias, groupQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateGroup() =>
            ExceptField("create_group");
        public MutationQueryBuilder WithCreateItem(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> itemName, QueryBuilderParameter<string?>? columnValues = null, QueryBuilderParameter<bool?>? createLabelsIfMissing = null, QueryBuilderParameter<string?>? groupID = null, QueryBuilderParameter<PositionRelative?>? positionRelativeMethod = null, QueryBuilderParameter<string?>? relativeTo = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            if (columnValues != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "column_values", ArgumentValue = columnValues });
            if (createLabelsIfMissing != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "create_labels_if_missing", ArgumentValue = createLabelsIfMissing });
            if (groupID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "group_id", ArgumentValue = groupID });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_name", ArgumentValue = itemName });
            if (positionRelativeMethod != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "position_relative_method", ArgumentValue = positionRelativeMethod });
            if (relativeTo != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "relative_to", ArgumentValue = relativeTo });
            return WithObjectField("create_item", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateItem() =>
            ExceptField("create_item");
        public MutationQueryBuilder WithCreateNotification(NotificationQueryBuilder notificationQueryBuilder, QueryBuilderParameter<string> targetID, QueryBuilderParameter<NotificationTargetType> targetType, QueryBuilderParameter<string> text, QueryBuilderParameter<string> userID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "target_id", ArgumentValue = targetID },
                new QueryBuilderArgumentInfo { ArgumentName = "target_type", ArgumentValue = targetType },
                new QueryBuilderArgumentInfo { ArgumentName = "text", ArgumentValue = text },
                new QueryBuilderArgumentInfo { ArgumentName = "user_id", ArgumentValue = userID }
            };
            return WithObjectField("create_notification", alias, notificationQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateNotification() =>
            ExceptField("create_notification");
        public MutationQueryBuilder WithCreateOrGetTag(TagQueryBuilder tagQueryBuilder, QueryBuilderParameter<string?>? boardID = null, QueryBuilderParameter<string?>? tagName = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (boardID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID });
            if (tagName != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "tag_name", ArgumentValue = tagName });
            return WithObjectField("create_or_get_tag", alias, tagQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateOrGetTag() =>
            ExceptField("create_or_get_tag");
        public MutationQueryBuilder WithCreateSubitem(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> itemName, QueryBuilderParameter<string> parentItemID, QueryBuilderParameter<string?>? columnValues = null, QueryBuilderParameter<bool?>? createLabelsIfMissing = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (columnValues != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "column_values", ArgumentValue = columnValues });
            if (createLabelsIfMissing != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "create_labels_if_missing", ArgumentValue = createLabelsIfMissing });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_name", ArgumentValue = itemName });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "parent_item_id", ArgumentValue = parentItemID });
            return WithObjectField("create_subitem", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateSubitem() =>
            ExceptField("create_subitem");
        public MutationQueryBuilder WithCreateWebhook(WebhookQueryBuilder webhookQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<WebhookEventType> @event, QueryBuilderParameter<string> url, QueryBuilderParameter<object?>? config = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            if (config != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "config", ArgumentValue = config });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "event", ArgumentValue = @event });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "url", ArgumentValue = url });
            return WithObjectField("create_webhook", alias, webhookQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateWebhook() =>
            ExceptField("create_webhook");
        public MutationQueryBuilder WithCreateWorkspace(WorkspaceQueryBuilder workspaceQueryBuilder, QueryBuilderParameter<WorkspaceKind> kind, QueryBuilderParameter<string> name, QueryBuilderParameter<string?>? accountProductID = null, QueryBuilderParameter<string?>? description = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (accountProductID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "account_product_id", ArgumentValue = accountProductID });
            if (description != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "description", ArgumentValue = description });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name });
            return WithObjectField("create_workspace", alias, workspaceQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateWorkspace() =>
            ExceptField("create_workspace");
        public MutationQueryBuilder WithDeleteBoard(BoardQueryBuilder boardQueryBuilder, QueryBuilderParameter<string> boardID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            return WithObjectField("delete_board", alias, boardQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteBoard() =>
            ExceptField("delete_board");
        public MutationQueryBuilder WithDeleteDocBlock(DocumentBlockIDOnlyQueryBuilder documentBlockIDOnlyQueryBuilder, QueryBuilderParameter<string> blockID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "block_id", ArgumentValue = blockID }
            };
            return WithObjectField("delete_doc_block", alias, documentBlockIDOnlyQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteDocBlock() =>
            ExceptField("delete_doc_block");
        public MutationQueryBuilder WithDeleteFolder(FolderQueryBuilder folderQueryBuilder, QueryBuilderParameter<string> folderID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "folder_id", ArgumentValue = folderID }
            };
            return WithObjectField("delete_folder", alias, folderQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteFolder() =>
            ExceptField("delete_folder");
        public MutationQueryBuilder WithDeleteGroup(GroupQueryBuilder groupQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> groupID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "group_id", ArgumentValue = groupID }
            };
            return WithObjectField("delete_group", alias, groupQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteGroup() =>
            ExceptField("delete_group");
        public MutationQueryBuilder WithDeleteItem(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string?>? itemID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });
            return WithObjectField("delete_item", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteItem() =>
            ExceptField("delete_item");
        public MutationQueryBuilder WithDeleteSubscribersFromBoard(UserQueryBuilder userQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<IEnumerable<string>> userIDs, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs }
            };
            return WithObjectField("delete_subscribers_from_board", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteSubscribersFromBoard() =>
            ExceptField("delete_subscribers_from_board");
        public MutationQueryBuilder WithDeleteTeamsFromBoard(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<IEnumerable<string>> teamIDs, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "team_ids", ArgumentValue = teamIDs }
            };
            return WithObjectField("delete_teams_from_board", alias, teamQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteTeamsFromBoard() =>
            ExceptField("delete_teams_from_board");
        public MutationQueryBuilder WithDeleteTeamsFromWorkspace(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<IEnumerable<string>> teamIDs, QueryBuilderParameter<string> workspaceID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "team_ids", ArgumentValue = teamIDs },
                new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID }
            };
            return WithObjectField("delete_teams_from_workspace", alias, teamQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteTeamsFromWorkspace() =>
            ExceptField("delete_teams_from_workspace");
        public MutationQueryBuilder WithDeleteUsersFromWorkspace(UserQueryBuilder userQueryBuilder, QueryBuilderParameter<IEnumerable<string>> userIDs, QueryBuilderParameter<string> workspaceID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs },
                new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID }
            };
            return WithObjectField("delete_users_from_workspace", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteUsersFromWorkspace() =>
            ExceptField("delete_users_from_workspace");
        public MutationQueryBuilder WithDeleteWebhook(WebhookQueryBuilder webhookQueryBuilder, QueryBuilderParameter<string> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("delete_webhook", alias, webhookQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteWebhook() =>
            ExceptField("delete_webhook");
        public MutationQueryBuilder WithDeleteWorkspace(WorkspaceQueryBuilder workspaceQueryBuilder, QueryBuilderParameter<string> workspaceID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID }
            };
            return WithObjectField("delete_workspace", alias, workspaceQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteWorkspace() =>
            ExceptField("delete_workspace");
        public MutationQueryBuilder WithDuplicateBoard(BoardDuplicationQueryBuilder boardDuplicationQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<DuplicateBoardType> duplicateType, QueryBuilderParameter<string?>? boardName = null, QueryBuilderParameter<string?>? folderID = null, QueryBuilderParameter<bool?>? keepSubscribers = null, QueryBuilderParameter<string?>? workspaceID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            if (boardName != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_name", ArgumentValue = boardName });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "duplicate_type", ArgumentValue = duplicateType });
            if (folderID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "folder_id", ArgumentValue = folderID });
            if (keepSubscribers != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "keep_subscribers", ArgumentValue = keepSubscribers });
            if (workspaceID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID });
            return WithObjectField("duplicate_board", alias, boardDuplicationQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDuplicateBoard() =>
            ExceptField("duplicate_board");
        public MutationQueryBuilder WithDuplicateGroup(GroupQueryBuilder groupQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> groupID, QueryBuilderParameter<bool?>? addToTop = null, QueryBuilderParameter<string?>? groupTitle = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (addToTop != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "add_to_top", ArgumentValue = addToTop });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "group_id", ArgumentValue = groupID });
            if (groupTitle != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "group_title", ArgumentValue = groupTitle });
            return WithObjectField("duplicate_group", alias, groupQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDuplicateGroup() =>
            ExceptField("duplicate_group");
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
        public MutationQueryBuilder ExceptDuplicateItem() =>
            ExceptField("duplicate_item");
        public MutationQueryBuilder WithIncreaseAppSubscriptionOperations(AppSubscriptionOperationsCounterQueryBuilder appSubscriptionOperationsCounterQueryBuilder, QueryBuilderParameter<int?>? incrementBy = null, QueryBuilderParameter<string?>? kind = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (incrementBy != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "increment_by", ArgumentValue = incrementBy });
            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });
            return WithObjectField("increase_app_subscription_operations", alias, appSubscriptionOperationsCounterQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptIncreaseAppSubscriptionOperations() =>
            ExceptField("increase_app_subscription_operations");
        public MutationQueryBuilder WithMoveItemToBoard(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> groupID, QueryBuilderParameter<string> itemID, QueryBuilderParameter<IEnumerable<ColumnMappingInput>>? columnsMapping = null, QueryBuilderParameter<IEnumerable<ColumnMappingInput>>? subitemsColumnsMapping = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            if (columnsMapping != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "columns_mapping", ArgumentValue = columnsMapping });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "group_id", ArgumentValue = groupID });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });
            if (subitemsColumnsMapping != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "subitems_columns_mapping", ArgumentValue = subitemsColumnsMapping });
            return WithObjectField("move_item_to_board", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptMoveItemToBoard() =>
            ExceptField("move_item_to_board");
        public MutationQueryBuilder WithMoveItemToGroup(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> groupID, QueryBuilderParameter<string?>? itemID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "group_id", ArgumentValue = groupID }
            };
            if (itemID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID });
            return WithObjectField("move_item_to_group", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptMoveItemToGroup() =>
            ExceptField("move_item_to_group");
        public MutationQueryBuilder WithRemoveMockAppSubscription(AppSubscriptionQueryBuilder appSubscriptionQueryBuilder, QueryBuilderParameter<string> appID, QueryBuilderParameter<string> partialSigningSecret, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "app_id", ArgumentValue = appID },
                new QueryBuilderArgumentInfo { ArgumentName = "partial_signing_secret", ArgumentValue = partialSigningSecret }
            };
            return WithObjectField("remove_mock_app_subscription", alias, appSubscriptionQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptRemoveMockAppSubscription() =>
            ExceptField("remove_mock_app_subscription");
        public MutationQueryBuilder WithRemoveUsersFromTeam(ChangeTeamMembershipsResultQueryBuilder changeTeamMembershipsResultQueryBuilder, QueryBuilderParameter<string> teamID, QueryBuilderParameter<IEnumerable<string>> userIDs, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "team_id", ArgumentValue = teamID },
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs }
            };
            return WithObjectField("remove_users_from_team", alias, changeTeamMembershipsResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptRemoveUsersFromTeam() =>
            ExceptField("remove_users_from_team");
        public MutationQueryBuilder WithSetBoardPermission(SetBoardPermissionResponseQueryBuilder setBoardPermissionResponseQueryBuilder, QueryBuilderParameter<BoardBasicRoleName> basicRoleName, QueryBuilderParameter<string> boardID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "basic_role_name", ArgumentValue = basicRoleName },
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            return WithObjectField("set_board_permission", alias, setBoardPermissionResponseQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptSetBoardPermission() =>
            ExceptField("set_board_permission");
        public MutationQueryBuilder WithSetMockAppSubscription(AppSubscriptionQueryBuilder appSubscriptionQueryBuilder, QueryBuilderParameter<string> appID, QueryBuilderParameter<string> partialSigningSecret, QueryBuilderParameter<string?>? billingPeriod = null, QueryBuilderParameter<bool?>? isTrial = null, QueryBuilderParameter<int?>? maxUnits = null, QueryBuilderParameter<string?>? planID = null, QueryBuilderParameter<int?>? pricingVersion = null, QueryBuilderParameter<object?>? renewalDate = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "app_id", ArgumentValue = appID }
            };
            if (billingPeriod != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "billing_period", ArgumentValue = billingPeriod });
            if (isTrial != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "is_trial", ArgumentValue = isTrial });
            if (maxUnits != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "max_units", ArgumentValue = maxUnits });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "partial_signing_secret", ArgumentValue = partialSigningSecret });
            if (planID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "plan_id", ArgumentValue = planID });
            if (pricingVersion != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "pricing_version", ArgumentValue = pricingVersion });
            if (renewalDate != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "renewal_date", ArgumentValue = renewalDate });
            return WithObjectField("set_mock_app_subscription", alias, appSubscriptionQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptSetMockAppSubscription() =>
            ExceptField("set_mock_app_subscription");
        public MutationQueryBuilder WithUpdateAssetsOnItem(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> columnID, QueryBuilderParameter<IEnumerable<FileInput>> files, QueryBuilderParameter<string> itemID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "column_id", ArgumentValue = columnID },
                new QueryBuilderArgumentInfo { ArgumentName = "files", ArgumentValue = files },
                new QueryBuilderArgumentInfo { ArgumentName = "item_id", ArgumentValue = itemID }
            };
            return WithObjectField("update_assets_on_item", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateAssetsOnItem() =>
            ExceptField("update_assets_on_item");
        public MutationQueryBuilder WithUpdateBoard(QueryBuilderParameter<BoardAttributes> boardAttribute, QueryBuilderParameter<string> boardID, QueryBuilderParameter<string> newValue, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_attribute", ArgumentValue = boardAttribute },
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "new_value", ArgumentValue = newValue }
            };
            return WithScalarField("update_board", alias, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateBoard() =>
            ExceptField("update_board");
        public MutationQueryBuilder WithUpdateBoardHierarchy(UpdateBoardHierarchyResultQueryBuilder updateBoardHierarchyResultQueryBuilder, QueryBuilderParameter<UpdateBoardHierarchyAttributesInput> attributes, QueryBuilderParameter<string> boardID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "attributes", ArgumentValue = attributes },
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            return WithObjectField("update_board_hierarchy", alias, updateBoardHierarchyResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateBoardHierarchy() =>
            ExceptField("update_board_hierarchy");
        public MutationQueryBuilder WithUpdateDocBlock(DocumentBlockQueryBuilder documentBlockQueryBuilder, QueryBuilderParameter<string> blockID, QueryBuilderParameter<object> content, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "block_id", ArgumentValue = blockID },
                new QueryBuilderArgumentInfo { ArgumentName = "content", ArgumentValue = content }
            };
            return WithObjectField("update_doc_block", alias, documentBlockQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateDocBlock() =>
            ExceptField("update_doc_block");
        public MutationQueryBuilder WithUpdateFolder(FolderQueryBuilder folderQueryBuilder, QueryBuilderParameter<string> folderID, QueryBuilderParameter<string?>? accountProductID = null, QueryBuilderParameter<FolderColor?>? color = null, QueryBuilderParameter<FolderCustomIcon?>? customIcon = null, QueryBuilderParameter<FolderFontWeight?>? fontWeight = null, QueryBuilderParameter<string?>? name = null, QueryBuilderParameter<string?>? parentFolderID = null, QueryBuilderParameter<DynamicPosition?>? position = null, QueryBuilderParameter<string?>? workspaceID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (accountProductID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "account_product_id", ArgumentValue = accountProductID });
            if (color != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "color", ArgumentValue = color });
            if (customIcon != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "custom_icon", ArgumentValue = customIcon });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "folder_id", ArgumentValue = folderID });
            if (fontWeight != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "font_weight", ArgumentValue = fontWeight });
            if (name != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name });
            if (parentFolderID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "parent_folder_id", ArgumentValue = parentFolderID });
            if (position != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "position", ArgumentValue = position });
            if (workspaceID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID });
            return WithObjectField("update_folder", alias, folderQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateFolder() =>
            ExceptField("update_folder");
        public MutationQueryBuilder WithUpdateGroup(GroupQueryBuilder groupQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<GroupAttributes> groupAttribute, QueryBuilderParameter<string> groupID, QueryBuilderParameter<string> newValue, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "group_attribute", ArgumentValue = groupAttribute },
                new QueryBuilderArgumentInfo { ArgumentName = "group_id", ArgumentValue = groupID },
                new QueryBuilderArgumentInfo { ArgumentName = "new_value", ArgumentValue = newValue }
            };
            return WithObjectField("update_group", alias, groupQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateGroup() =>
            ExceptField("update_group");
        public MutationQueryBuilder WithUpdateOverviewHierarchy(UpdateOverviewHierarchyQueryBuilder updateOverviewHierarchyQueryBuilder, QueryBuilderParameter<UpdateOverviewHierarchyAttributesInput> attributes, QueryBuilderParameter<string> overviewID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "attributes", ArgumentValue = attributes },
                new QueryBuilderArgumentInfo { ArgumentName = "overview_id", ArgumentValue = overviewID }
            };
            return WithObjectField("update_overview_hierarchy", alias, updateOverviewHierarchyQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateOverviewHierarchy() =>
            ExceptField("update_overview_hierarchy");
        public MutationQueryBuilder WithUpdateWorkspace(WorkspaceQueryBuilder workspaceQueryBuilder, QueryBuilderParameter<UpdateWorkspaceAttributesInput> attributes, QueryBuilderParameter<string?>? id = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "attributes", ArgumentValue = attributes }
            };
            if (id != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id });
            return WithObjectField("update_workspace", alias, workspaceQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateWorkspace() =>
            ExceptField("update_workspace");
        public MutationQueryBuilder WithUseTemplate(TemplateQueryBuilder templateQueryBuilder, QueryBuilderParameter<int> templateID, QueryBuilderParameter<BoardKind?>? boardKind = null, QueryBuilderParameter<IEnumerable<int?>>? boardOwnerIDs = null, QueryBuilderParameter<IEnumerable<int?>>? boardOwnerTeamIDs = null, QueryBuilderParameter<IEnumerable<int?>>? boardSubscriberIDs = null, QueryBuilderParameter<IEnumerable<int?>>? boardSubscriberTeamsIDs = null, QueryBuilderParameter<string?>? callbackURLOnComplete = null, QueryBuilderParameter<int?>? destinationFolderID = null, QueryBuilderParameter<string?>? destinationFolderName = null, QueryBuilderParameter<string?>? destinationName = null, QueryBuilderParameter<int?>? destinationWorkspaceID = null, QueryBuilderParameter<bool?>? skipTargetFolderCreation = null, QueryBuilderParameter<object?>? solutionExtraOptions = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
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
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "template_id", ArgumentValue = templateID });
            return WithObjectField("use_template", alias, templateQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUseTemplate() =>
            ExceptField("use_template");
        public MutationQueryBuilder WithConvertBoardToProject(ConvertBoardToProjectResultQueryBuilder convertBoardToProjectResultQueryBuilder, QueryBuilderParameter<ConvertBoardToProjectInput> input, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "input", ArgumentValue = input }
            };
            return WithObjectField("convert_board_to_project", alias, convertBoardToProjectResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptConvertBoardToProject() =>
            ExceptField("convert_board_to_project");
        public MutationQueryBuilder WithUpdateNotificationSetting(NotificationSettingQueryBuilder notificationSettingQueryBuilder, QueryBuilderParameter<ScopeType> scopeType, QueryBuilderParameter<string> settingKind, QueryBuilderParameter<ChannelType> channel, QueryBuilderParameter<bool> enabled, QueryBuilderParameter<int?>? scopeID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "scope_type", ArgumentValue = scopeType }
            };
            if (scopeID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "scope_id", ArgumentValue = scopeID });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "setting_kind", ArgumentValue = settingKind });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "channel", ArgumentValue = channel });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "enabled", ArgumentValue = enabled });
            return WithObjectField("update_notification_setting", alias, notificationSettingQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateNotificationSetting() =>
            ExceptField("update_notification_setting");
        public MutationQueryBuilder WithUpdateMuteBoardSettings(BoardMuteSettingsQueryBuilder boardMuteSettingsQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<BoardMuteState> muteState, QueryBuilderParameter<IEnumerable<CustomizableBoardSettings>>? enabled = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "mute_state", ArgumentValue = muteState }
            };
            if (enabled != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "enabled", ArgumentValue = enabled });
            return WithObjectField("update_mute_board_settings", alias, boardMuteSettingsQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateMuteBoardSettings() =>
            ExceptField("update_mute_board_settings");
        public MutationQueryBuilder WithCreateObject(ObjectQueryBuilder objectQueryBuilder, QueryBuilderParameter<string> name, QueryBuilderParameter<PrivacyKind> privacyKind, QueryBuilderParameter<string> objectTypeUniqueKey, QueryBuilderParameter<string?>? workspaceID = null, QueryBuilderParameter<string?>? description = null, QueryBuilderParameter<string?>? folderID = null, QueryBuilderParameter<IEnumerable<string>>? ownerIDs = null, QueryBuilderParameter<IEnumerable<string>>? ownerTeamIDs = null, QueryBuilderParameter<IEnumerable<string>>? subscriberIDs = null, QueryBuilderParameter<IEnumerable<string>>? subscriberTeamsIDs = null, QueryBuilderParameter<object?>? payload = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name },
                new QueryBuilderArgumentInfo { ArgumentName = "privacy_kind", ArgumentValue = privacyKind }
            };
            if (workspaceID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID });
            if (description != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "description", ArgumentValue = description });
            if (folderID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "folder_id", ArgumentValue = folderID });
            if (ownerIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "owner_ids", ArgumentValue = ownerIDs });
            if (ownerTeamIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "owner_team_ids", ArgumentValue = ownerTeamIDs });
            if (subscriberIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "subscriber_ids", ArgumentValue = subscriberIDs });
            if (subscriberTeamsIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "subscriber_teams_ids", ArgumentValue = subscriberTeamsIDs });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "object_type_unique_key", ArgumentValue = objectTypeUniqueKey });
            if (payload != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "payload", ArgumentValue = payload });
            return WithObjectField("create_object", alias, objectQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateObject() =>
            ExceptField("create_object");
        public MutationQueryBuilder WithDeleteObject(ObjectQueryBuilder objectQueryBuilder, QueryBuilderParameter<string> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("delete_object", alias, objectQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteObject() =>
            ExceptField("delete_object");
        public MutationQueryBuilder WithArchiveObject(ObjectQueryBuilder objectQueryBuilder, QueryBuilderParameter<string> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("archive_object", alias, objectQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptArchiveObject() =>
            ExceptField("archive_object");
        public MutationQueryBuilder WithAddSubscribersToObject(ObjectQueryBuilder objectQueryBuilder, QueryBuilderParameter<string> id, QueryBuilderParameter<IEnumerable<string>> userIDs, QueryBuilderParameter<SubscriberKind?>? kind = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id },
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs }
            };
            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });
            return WithObjectField("add_subscribers_to_object", alias, objectQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptAddSubscribersToObject() =>
            ExceptField("add_subscribers_to_object");
        public MutationQueryBuilder WithUpdateObject(ObjectQueryBuilder objectQueryBuilder, QueryBuilderParameter<string> id, QueryBuilderParameter<UpdateObjectInput> input, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id },
                new QueryBuilderArgumentInfo { ArgumentName = "input", ArgumentValue = input }
            };
            return WithObjectField("update_object", alias, objectQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateObject() =>
            ExceptField("update_object");
        public MutationQueryBuilder WithPublishObject(ObjectOperationResponseQueryBuilder objectOperationResponseQueryBuilder, QueryBuilderParameter<string> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("publish_object", alias, objectOperationResponseQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptPublishObject() =>
            ExceptField("publish_object");
        public MutationQueryBuilder WithUnpublishObject(ObjectOperationResponseQueryBuilder objectOperationResponseQueryBuilder, QueryBuilderParameter<string> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("unpublish_object", alias, objectOperationResponseQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUnpublishObject() =>
            ExceptField("unpublish_object");
        public MutationQueryBuilder WithConnectProjectToPortfolio(ConnectProjectResultQueryBuilder connectProjectResultQueryBuilder, QueryBuilderParameter<string> projectBoardID, QueryBuilderParameter<string> portfolioBoardID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "projectBoardId", ArgumentValue = projectBoardID },
                new QueryBuilderArgumentInfo { ArgumentName = "portfolioBoardId", ArgumentValue = portfolioBoardID }
            };
            return WithObjectField("connect_project_to_portfolio", alias, connectProjectResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptConnectProjectToPortfolio() =>
            ExceptField("connect_project_to_portfolio");
        public MutationQueryBuilder WithCreatePortfolio(CreatePortfolioResultQueryBuilder createPortfolioResultQueryBuilder, QueryBuilderParameter<string> boardName, QueryBuilderParameter<string> boardPrivacy, QueryBuilderParameter<int?>? destinationWorkspaceID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "boardName", ArgumentValue = boardName },
                new QueryBuilderArgumentInfo { ArgumentName = "boardPrivacy", ArgumentValue = boardPrivacy }
            };
            if (destinationWorkspaceID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "destinationWorkspaceId", ArgumentValue = destinationWorkspaceID });
            return WithObjectField("create_portfolio", alias, createPortfolioResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreatePortfolio() =>
            ExceptField("create_portfolio");
        public MutationQueryBuilder WithCreateTeam(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<CreateTeamAttributesInput> input, QueryBuilderParameter<CreateTeamOptionsInput?>? options = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "input", ArgumentValue = input }
            };
            if (options != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "options", ArgumentValue = options });
            return WithObjectField("create_team", alias, teamQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateTeam() =>
            ExceptField("create_team");
        public MutationQueryBuilder WithActivateUsers(ActivateUsersResultQueryBuilder activateUsersResultQueryBuilder, QueryBuilderParameter<IEnumerable<string>> userIDs, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs }
            };
            return WithObjectField("activate_users", alias, activateUsersResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptActivateUsers() =>
            ExceptField("activate_users");
        public MutationQueryBuilder WithDeactivateUsers(DeactivateUsersResultQueryBuilder deactivateUsersResultQueryBuilder, QueryBuilderParameter<IEnumerable<string>> userIDs, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs }
            };
            return WithObjectField("deactivate_users", alias, deactivateUsersResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeactivateUsers() =>
            ExceptField("deactivate_users");
        public MutationQueryBuilder WithDeleteTeam(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<string> teamID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "team_id", ArgumentValue = teamID }
            };
            return WithObjectField("delete_team", alias, teamQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteTeam() =>
            ExceptField("delete_team");
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
        public MutationQueryBuilder ExceptUpdateUsersRole() =>
            ExceptField("update_users_role");
        public MutationQueryBuilder WithAssignTeamOwners(AssignTeamOwnersResultQueryBuilder assignTeamOwnersResultQueryBuilder, QueryBuilderParameter<string> teamID, QueryBuilderParameter<IEnumerable<string>> userIDs, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "team_id", ArgumentValue = teamID },
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs }
            };
            return WithObjectField("assign_team_owners", alias, assignTeamOwnersResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptAssignTeamOwners() =>
            ExceptField("assign_team_owners");
        public MutationQueryBuilder WithRemoveTeamOwners(RemoveTeamOwnersResultQueryBuilder removeTeamOwnersResultQueryBuilder, QueryBuilderParameter<string> teamID, QueryBuilderParameter<IEnumerable<string>> userIDs, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "team_id", ArgumentValue = teamID },
                new QueryBuilderArgumentInfo { ArgumentName = "user_ids", ArgumentValue = userIDs }
            };
            return WithObjectField("remove_team_owners", alias, removeTeamOwnersResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptRemoveTeamOwners() =>
            ExceptField("remove_team_owners");
        public MutationQueryBuilder WithUpdateEmailDomain(UpdateEmailDomainResultQueryBuilder updateEmailDomainResultQueryBuilder, QueryBuilderParameter<UpdateEmailDomainAttributesInput> input, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "input", ArgumentValue = input }
            };
            return WithObjectField("update_email_domain", alias, updateEmailDomainResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateEmailDomain() =>
            ExceptField("update_email_domain");
        public MutationQueryBuilder WithUpdateMultipleUsers(UpdateUserAttributesResultQueryBuilder updateUserAttributesResultQueryBuilder, QueryBuilderParameter<IEnumerable<UserUpdateInput>> userUpdates, QueryBuilderParameter<bool?>? bypassConfirmationForClaimedDomains = null, QueryBuilderParameter<bool?>? useAsyncMode = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "user_updates", ArgumentValue = userUpdates }
            };
            if (bypassConfirmationForClaimedDomains != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "bypass_confirmation_for_claimed_domains", ArgumentValue = bypassConfirmationForClaimedDomains });
            if (useAsyncMode != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "use_async_mode", ArgumentValue = useAsyncMode });
            return WithObjectField("update_multiple_users", alias, updateUserAttributesResultQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateMultipleUsers() =>
            ExceptField("update_multiple_users");
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
        public MutationQueryBuilder ExceptInviteUsers() =>
            ExceptField("invite_users");
        public MutationQueryBuilder WithCreateWidget(WidgetQueryBuilder widgetQueryBuilder, QueryBuilderParameter<WidgetParentInput> parent, QueryBuilderParameter<ExternalWidget> kind, QueryBuilderParameter<string> name, QueryBuilderParameter<object> settings, QueryBuilderParameter<ItemsQueryGroup?>? filter = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "parent", ArgumentValue = parent },
                new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind },
                new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name },
                new QueryBuilderArgumentInfo { ArgumentName = "settings", ArgumentValue = settings }
            };
            if (filter != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "filter", ArgumentValue = filter });
            return WithObjectField("create_widget", alias, widgetQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateWidget() =>
            ExceptField("create_widget");
        public MutationQueryBuilder WithDeleteWidget(QueryBuilderParameter<string> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithScalarField("delete_widget", alias, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteWidget() =>
            ExceptField("delete_widget");
        public MutationQueryBuilder WithCreateDashboard(DashboardQueryBuilder dashboardQueryBuilder, QueryBuilderParameter<string> name, QueryBuilderParameter<string> workspaceID, QueryBuilderParameter<IEnumerable<string>> boardIDs, QueryBuilderParameter<DashboardKind?>? kind = null, QueryBuilderParameter<string?>? boardFolderID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name },
                new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID },
                new QueryBuilderArgumentInfo { ArgumentName = "board_ids", ArgumentValue = boardIDs }
            };
            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });
            if (boardFolderID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_folder_id", ArgumentValue = boardFolderID });
            return WithObjectField("create_dashboard", alias, dashboardQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateDashboard() =>
            ExceptField("create_dashboard");
        public MutationQueryBuilder WithUpdateDashboard(DashboardQueryBuilder dashboardQueryBuilder, QueryBuilderParameter<string> id, QueryBuilderParameter<string?>? name = null, QueryBuilderParameter<string?>? workspaceID = null, QueryBuilderParameter<DashboardKind?>? kind = null, QueryBuilderParameter<string?>? boardFolderID = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            if (name != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name });
            if (workspaceID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_id", ArgumentValue = workspaceID });
            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });
            if (boardFolderID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_folder_id", ArgumentValue = boardFolderID });
            return WithObjectField("update_dashboard", alias, dashboardQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateDashboard() =>
            ExceptField("update_dashboard");
        public MutationQueryBuilder WithDeleteDashboard(QueryBuilderParameter<string> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithScalarField("delete_dashboard", alias, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteDashboard() =>
            ExceptField("delete_dashboard");
        public MutationQueryBuilder WithUpdateForm(ResponseFormQueryBuilder responseFormQueryBuilder, QueryBuilderParameter<string> formToken, QueryBuilderParameter<UpdateFormInput> input, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "formToken", ArgumentValue = formToken },
                new QueryBuilderArgumentInfo { ArgumentName = "input", ArgumentValue = input }
            };
            return WithObjectField("update_form", alias, responseFormQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateForm() =>
            ExceptField("update_form");
        public MutationQueryBuilder WithUpdateFormSettings(ResponseFormQueryBuilder responseFormQueryBuilder, QueryBuilderParameter<string> formToken, QueryBuilderParameter<UpdateFormSettingsInput> settings, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "formToken", ArgumentValue = formToken },
                new QueryBuilderArgumentInfo { ArgumentName = "settings", ArgumentValue = settings }
            };
            return WithObjectField("update_form_settings", alias, responseFormQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateFormSettings() =>
            ExceptField("update_form_settings");
        public MutationQueryBuilder WithCreateFormQuestion(FormQuestionQueryBuilder formQuestionQueryBuilder, QueryBuilderParameter<string> formToken, QueryBuilderParameter<CreateQuestionInput> question, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "formToken", ArgumentValue = formToken },
                new QueryBuilderArgumentInfo { ArgumentName = "question", ArgumentValue = question }
            };
            return WithObjectField("create_form_question", alias, formQuestionQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateFormQuestion() =>
            ExceptField("create_form_question");
        public MutationQueryBuilder WithUpdateFormQuestion(FormQuestionQueryBuilder formQuestionQueryBuilder, QueryBuilderParameter<string> formToken, QueryBuilderParameter<string> questionID, QueryBuilderParameter<UpdateQuestionInput> question, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "formToken", ArgumentValue = formToken },
                new QueryBuilderArgumentInfo { ArgumentName = "questionId", ArgumentValue = questionID },
                new QueryBuilderArgumentInfo { ArgumentName = "question", ArgumentValue = question }
            };
            return WithObjectField("update_form_question", alias, formQuestionQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateFormQuestion() =>
            ExceptField("update_form_question");
        public MutationQueryBuilder WithDeleteQuestion(QueryBuilderParameter<string> formToken, QueryBuilderParameter<string> questionID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "formToken", ArgumentValue = formToken },
                new QueryBuilderArgumentInfo { ArgumentName = "questionId", ArgumentValue = questionID }
            };
            return WithScalarField("delete_question", alias, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteQuestion() =>
            ExceptField("delete_question");
        public MutationQueryBuilder WithActivateForm(QueryBuilderParameter<string> formToken, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "formToken", ArgumentValue = formToken }
            };
            return WithScalarField("activate_form", alias, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptActivateForm() =>
            ExceptField("activate_form");
        public MutationQueryBuilder WithDeactivateForm(QueryBuilderParameter<string> formToken, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "formToken", ArgumentValue = formToken }
            };
            return WithScalarField("deactivate_form", alias, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeactivateForm() =>
            ExceptField("deactivate_form");
        public MutationQueryBuilder WithShortenFormURL(FormShortenedLinkQueryBuilder formShortenedLinkQueryBuilder, QueryBuilderParameter<string> formToken, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "formToken", ArgumentValue = formToken }
            };
            return WithObjectField("shorten_form_url", alias, formShortenedLinkQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptShortenFormURL() =>
            ExceptField("shorten_form_url");
        public MutationQueryBuilder WithCreateFormTag(FormTagQueryBuilder formTagQueryBuilder, QueryBuilderParameter<string> formToken, QueryBuilderParameter<CreateFormTagInput> tag, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "formToken", ArgumentValue = formToken },
                new QueryBuilderArgumentInfo { ArgumentName = "tag", ArgumentValue = tag }
            };
            return WithObjectField("create_form_tag", alias, formTagQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateFormTag() =>
            ExceptField("create_form_tag");
        public MutationQueryBuilder WithUpdateFormTag(QueryBuilderParameter<string> formToken, QueryBuilderParameter<string> tagID, QueryBuilderParameter<UpdateFormTagInput> tag, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "formToken", ArgumentValue = formToken },
                new QueryBuilderArgumentInfo { ArgumentName = "tagId", ArgumentValue = tagID },
                new QueryBuilderArgumentInfo { ArgumentName = "tag", ArgumentValue = tag }
            };
            return WithScalarField("update_form_tag", alias, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptUpdateFormTag() =>
            ExceptField("update_form_tag");
        public MutationQueryBuilder WithDeleteFormTag(QueryBuilderParameter<string> formToken, QueryBuilderParameter<string> tagID, QueryBuilderParameter<DeleteFormTagInput?>? options = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "formToken", ArgumentValue = formToken },
                new QueryBuilderArgumentInfo { ArgumentName = "tagId", ArgumentValue = tagID }
            };
            if (options != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "options", ArgumentValue = options });
            return WithScalarField("delete_form_tag", alias, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptDeleteFormTag() =>
            ExceptField("delete_form_tag");
        public MutationQueryBuilder WithCreateForm(DehydratedFormResponseQueryBuilder dehydratedFormResponseQueryBuilder, QueryBuilderParameter<string> destinationWorkspaceID, QueryBuilderParameter<string?>? destinationFolderID = null, QueryBuilderParameter<string?>? destinationFolderName = null, QueryBuilderParameter<BoardKind?>? boardKind = null, QueryBuilderParameter<string?>? destinationName = null, QueryBuilderParameter<IEnumerable<string>>? boardOwnerIDs = null, QueryBuilderParameter<IEnumerable<string>>? boardOwnerTeamIDs = null, QueryBuilderParameter<IEnumerable<string>>? boardSubscriberIDs = null, QueryBuilderParameter<IEnumerable<string>>? boardSubscriberTeamsIDs = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "destination_workspace_id", ArgumentValue = destinationWorkspaceID }
            };
            if (destinationFolderID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "destination_folder_id", ArgumentValue = destinationFolderID });
            if (destinationFolderName != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "destination_folder_name", ArgumentValue = destinationFolderName });
            if (boardKind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_kind", ArgumentValue = boardKind });
            if (destinationName != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "destination_name", ArgumentValue = destinationName });
            if (boardOwnerIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_owner_ids", ArgumentValue = boardOwnerIDs });
            if (boardOwnerTeamIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_owner_team_ids", ArgumentValue = boardOwnerTeamIDs });
            if (boardSubscriberIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_subscriber_ids", ArgumentValue = boardSubscriberIDs });
            if (boardSubscriberTeamsIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_subscriber_teams_ids", ArgumentValue = boardSubscriberTeamsIDs });
            return WithObjectField("create_form", alias, dehydratedFormResponseQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptCreateForm() =>
            ExceptField("create_form");
        public MutationQueryBuilder WithSetFormPassword(ResponseFormQueryBuilder responseFormQueryBuilder, QueryBuilderParameter<string> formToken, QueryBuilderParameter<SetFormPasswordInput> input, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "formToken", ArgumentValue = formToken },
                new QueryBuilderArgumentInfo { ArgumentName = "input", ArgumentValue = input }
            };
            return WithObjectField("set_form_password", alias, responseFormQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public MutationQueryBuilder ExceptSetFormPassword() =>
            ExceptField("set_form_password");
    }
}

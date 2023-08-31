using System.Collections.Generic;

namespace MondayApi.Schema {
    public class UserQueryBuilder : GraphQlQueryBuilder<UserQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "account", IsComplex = true, QueryBuilderType = typeof(AccountQueryBuilder) },
            new GraphQlFieldMetadata { Name = "birthday", IsComplex = true },
            new GraphQlFieldMetadata { Name = "country_code" },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "current_language" },
            new GraphQlFieldMetadata { Name = "email" },
            new GraphQlFieldMetadata { Name = "enabled" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "is_admin" },
            new GraphQlFieldMetadata { Name = "is_guest" },
            new GraphQlFieldMetadata { Name = "is_pending" },
            new GraphQlFieldMetadata { Name = "is_verified" },
            new GraphQlFieldMetadata { Name = "is_view_only" },
            new GraphQlFieldMetadata { Name = "join_date", IsComplex = true },
            new GraphQlFieldMetadata { Name = "last_activity", IsComplex = true },
            new GraphQlFieldMetadata { Name = "location" },
            new GraphQlFieldMetadata { Name = "mobile_phone" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "out_of_office", IsComplex = true, QueryBuilderType = typeof(OutOfOfficeQueryBuilder) },
            new GraphQlFieldMetadata { Name = "phone" },
            new GraphQlFieldMetadata { Name = "photo_original" },
            new GraphQlFieldMetadata { Name = "photo_small" },
            new GraphQlFieldMetadata { Name = "photo_thumb" },
            new GraphQlFieldMetadata { Name = "photo_thumb_small" },
            new GraphQlFieldMetadata { Name = "photo_tiny" },
            new GraphQlFieldMetadata { Name = "sign_up_product_kind" },
            new GraphQlFieldMetadata { Name = "teams", IsComplex = true, QueryBuilderType = typeof(TeamQueryBuilder) },
            new GraphQlFieldMetadata { Name = "time_zone_identifier" },
            new GraphQlFieldMetadata { Name = "title" },
            new GraphQlFieldMetadata { Name = "url" },
            new GraphQlFieldMetadata { Name = "utc_hours_diff" }
        };

        protected override string TypeName { get { return "User"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public UserQueryBuilder WithAccount(AccountQueryBuilder accountQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("account", alias, accountQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptAccount() {
            return ExceptField("account");
        }

        public UserQueryBuilder WithBirthday(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("birthday", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptBirthday() {
            return ExceptField("birthday");
        }

        public UserQueryBuilder WithCountryCode(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("country_code", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptCountryCode() {
            return ExceptField("country_code");
        }

        public UserQueryBuilder WithCreatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("created_at", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptCreatedAt() {
            return ExceptField("created_at");
        }

        public UserQueryBuilder WithCurrentLanguage(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("current_language", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptCurrentLanguage() {
            return ExceptField("current_language");
        }

        public UserQueryBuilder WithEmail(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("email", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptEmail() {
            return ExceptField("email");
        }

        public UserQueryBuilder WithEnabled(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("enabled", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptEnabled() {
            return ExceptField("enabled");
        }

        public UserQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptId() {
            return ExceptField("id");
        }

        public UserQueryBuilder WithIsAdmin(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("is_admin", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptIsAdmin() {
            return ExceptField("is_admin");
        }

        public UserQueryBuilder WithIsGuest(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("is_guest", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptIsGuest() {
            return ExceptField("is_guest");
        }

        public UserQueryBuilder WithIsPending(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("is_pending", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptIsPending() {
            return ExceptField("is_pending");
        }

        public UserQueryBuilder WithIsVerified(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("is_verified", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptIsVerified() {
            return ExceptField("is_verified");
        }

        public UserQueryBuilder WithIsViewOnly(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("is_view_only", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptIsViewOnly() {
            return ExceptField("is_view_only");
        }

        public UserQueryBuilder WithJoinDate(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("join_date", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptJoinDate() {
            return ExceptField("join_date");
        }

        public UserQueryBuilder WithLastActivity(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("last_activity", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptLastActivity() {
            return ExceptField("last_activity");
        }

        public UserQueryBuilder WithLocation(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("location", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptLocation() {
            return ExceptField("location");
        }

        public UserQueryBuilder WithMobilePhone(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("mobile_phone", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptMobilePhone() {
            return ExceptField("mobile_phone");
        }

        public UserQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptName() {
            return ExceptField("name");
        }

        public UserQueryBuilder WithOutOfOffice(OutOfOfficeQueryBuilder outOfOfficeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("out_of_office", alias, outOfOfficeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptOutOfOffice() {
            return ExceptField("out_of_office");
        }

        public UserQueryBuilder WithPhone(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("phone", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptPhone() {
            return ExceptField("phone");
        }

        public UserQueryBuilder WithPhotoOriginal(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("photo_original", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptPhotoOriginal() {
            return ExceptField("photo_original");
        }

        public UserQueryBuilder WithPhotoSmall(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("photo_small", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptPhotoSmall() {
            return ExceptField("photo_small");
        }

        public UserQueryBuilder WithPhotoThumb(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("photo_thumb", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptPhotoThumb() {
            return ExceptField("photo_thumb");
        }

        public UserQueryBuilder WithPhotoThumbSmall(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("photo_thumb_small", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptPhotoThumbSmall() {
            return ExceptField("photo_thumb_small");
        }

        public UserQueryBuilder WithPhotoTiny(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("photo_tiny", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptPhotoTiny() {
            return ExceptField("photo_tiny");
        }

        public UserQueryBuilder WithSignUpProductKind(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("sign_up_product_kind", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptSignUpProductKind() {
            return ExceptField("sign_up_product_kind");
        }

        public UserQueryBuilder WithTeams(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<IEnumerable<int?>> ids = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });

            return WithObjectField("teams", alias, teamQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public UserQueryBuilder ExceptTeams() {
            return ExceptField("teams");
        }

        public UserQueryBuilder WithTimeZoneIdentifier(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("time_zone_identifier", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptTimeZoneIdentifier() {
            return ExceptField("time_zone_identifier");
        }

        public UserQueryBuilder WithTitle(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("title", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptTitle() {
            return ExceptField("title");
        }

        public UserQueryBuilder WithUrl(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("url", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptUrl() {
            return ExceptField("url");
        }

        public UserQueryBuilder WithUtcHoursDiff(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("utc_hours_diff", alias, new GraphQlDirective[] { include, skip });
        }

        public UserQueryBuilder ExceptUtcHoursDiff() {
            return ExceptField("utc_hours_diff");
        }
    }
}

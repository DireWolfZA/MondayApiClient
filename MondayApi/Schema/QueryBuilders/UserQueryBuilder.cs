using System.Collections.Generic;

namespace MondayApi.Schema {
    public class UserQueryBuilder : GraphQlQueryBuilder<UserQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "account", IsComplex = true, QueryBuilderType = typeof(AccountQueryBuilder) },
            new GraphQlFieldMetadata { Name = "account_products", IsComplex = true, QueryBuilderType = typeof(AccountProductQueryBuilder) },
            new GraphQlFieldMetadata { Name = "birthday" },
            new GraphQlFieldMetadata { Name = "country_code" },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "current_language" },
            new GraphQlFieldMetadata { Name = "email" },
            new GraphQlFieldMetadata { Name = "enabled" },
            new GraphQlFieldMetadata { Name = "encrypt_api_token" },
            new GraphQlFieldMetadata { Name = "is_admin" },
            new GraphQlFieldMetadata { Name = "is_guest" },
            new GraphQlFieldMetadata { Name = "is_pending" },
            new GraphQlFieldMetadata { Name = "is_verified" },
            new GraphQlFieldMetadata { Name = "is_view_only" },
            new GraphQlFieldMetadata { Name = "join_date" },
            new GraphQlFieldMetadata { Name = "last_activity" },
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

        protected override string TypeName => "User";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public UserQueryBuilder WithTeams(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<IEnumerable<string>>? ids = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            return WithObjectField("teams", alias, teamQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }

        public UserQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptID() =>
            ExceptField("id");
        public UserQueryBuilder WithAccount(AccountQueryBuilder accountQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("account", alias, accountQueryBuilder, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptAccount() =>
            ExceptField("account");
        public UserQueryBuilder WithAccountProducts(AccountProductQueryBuilder accountProductQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("account_products", alias, accountProductQueryBuilder, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptAccountProducts() =>
            ExceptField("account_products");
        public UserQueryBuilder WithBirthday(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("birthday", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptBirthday() =>
            ExceptField("birthday");
        public UserQueryBuilder WithCountryCode(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("country_code", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptCountryCode() =>
            ExceptField("country_code");
        public UserQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public UserQueryBuilder WithCurrentLanguage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("current_language", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptCurrentLanguage() =>
            ExceptField("current_language");
        public UserQueryBuilder WithEmail(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("email", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptEmail() =>
            ExceptField("email");
        public UserQueryBuilder WithEnabled(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("enabled", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptEnabled() =>
            ExceptField("enabled");
        public UserQueryBuilder WithEncryptApiToken(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("encrypt_api_token", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptEncryptApiToken() =>
            ExceptField("encrypt_api_token");
        public UserQueryBuilder WithIsAdmin(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("is_admin", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptIsAdmin() =>
            ExceptField("is_admin");
        public UserQueryBuilder WithIsGuest(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("is_guest", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptIsGuest() =>
            ExceptField("is_guest");
        public UserQueryBuilder WithIsPending(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("is_pending", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptIsPending() =>
            ExceptField("is_pending");
        public UserQueryBuilder WithIsVerified(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("is_verified", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptIsVerified() =>
            ExceptField("is_verified");
        public UserQueryBuilder WithIsViewOnly(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("is_view_only", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptIsViewOnly() =>
            ExceptField("is_view_only");
        public UserQueryBuilder WithJoinDate(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("join_date", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptJoinDate() =>
            ExceptField("join_date");
        public UserQueryBuilder WithLastActivity(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("last_activity", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptLastActivity() =>
            ExceptField("last_activity");
        public UserQueryBuilder WithLocation(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("location", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptLocation() =>
            ExceptField("location");
        public UserQueryBuilder WithMobilePhone(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("mobile_phone", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptMobilePhone() =>
            ExceptField("mobile_phone");
        public UserQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptName() =>
            ExceptField("name");
        public UserQueryBuilder WithOutOfOffice(OutOfOfficeQueryBuilder outOfOfficeQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("out_of_office", alias, outOfOfficeQueryBuilder, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptOutOfOffice() =>
            ExceptField("out_of_office");
        public UserQueryBuilder WithPhone(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("phone", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptPhone() =>
            ExceptField("phone");
        public UserQueryBuilder WithPhotoOriginal(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("photo_original", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptPhotoOriginal() =>
            ExceptField("photo_original");
        public UserQueryBuilder WithPhotoSmall(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("photo_small", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptPhotoSmall() =>
            ExceptField("photo_small");
        public UserQueryBuilder WithPhotoThumb(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("photo_thumb", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptPhotoThumb() =>
            ExceptField("photo_thumb");
        public UserQueryBuilder WithPhotoThumbSmall(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("photo_thumb_small", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptPhotoThumbSmall() =>
            ExceptField("photo_thumb_small");
        public UserQueryBuilder WithPhotoTiny(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("photo_tiny", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptPhotoTiny() =>
            ExceptField("photo_tiny");
        public UserQueryBuilder WithSignUpProductKind(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("sign_up_product_kind", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptSignUpProductKind() =>
            ExceptField("sign_up_product_kind");
        public UserQueryBuilder ExceptTeams() =>
            ExceptField("teams");
        public UserQueryBuilder WithTimeZoneIdentifier(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("time_zone_identifier", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptTimeZoneIdentifier() =>
            ExceptField("time_zone_identifier");
        public UserQueryBuilder WithTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("title", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptTitle() =>
            ExceptField("title");
        public UserQueryBuilder WithURL(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("url", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptURL() =>
            ExceptField("url");
        public UserQueryBuilder WithUtcHoursDiff(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("utc_hours_diff", alias, new GraphQlDirective?[] { include, skip });
        public UserQueryBuilder ExceptUtcHoursDiff() =>
            ExceptField("utc_hours_diff");
    }
}

# MondayApiClient [![Build status](https://ci.appveyor.com/api/projects/status/dud56wnemhwb39m7)](https://ci.appveyor.com/project/Walkman100/MondayApiClient)
A C# wrapper for the [Monday.com API](https://developer.monday.com/api-reference/reference)

Current API version is **`2024-10`** - this can be seen in [MondayApiClient.cs](/MondayApi/MondayApiClient.cs)

---
- Built using `netstandard2.0` - compatible with .Net Framework
- Uses [GraphQL.Client](https://github.com/graphql-dotnet/graphql-client) for most request functionality, however MondayAPI returns non-GraphQL-standard errors so a [special serializer](/MondayApi/Utils/DebugSerializer.cs) is used (thanks to [this comment](https://github.com/graphql-dotnet/graphql-client/issues/527#issuecomment-1655503961))
- I use [Husqvik/GraphQlClientGenerator](https://github.com/Husqvik/GraphQlClientGenerator) to generate the [Schema](/MondayApi/Schema) used to generate requests - install with `dotnet tool install --global graphqlclientgenerator.tool` and see [generate api schema.cmd](/MondayApi/generate%20api%20schema.cmd)
- Thanks to [this comment](https://github.com/graphql-dotnet/graphql-client/issues/216#issuecomment-625118457), file uploads are supported by [MondayFileUploadRequest.cs](/MondayApi/Utils/MondayFileUploadRequest.cs) - the variable `file` must be used in the request
- There are a couple bugs/quirks noticed in the Monday API that are mitigated by this project:
  - Asset columns have nonsense CreatedAt values - e.g. `55686-09-26T02:33:47+00:00` - see [AssetActions.cs](/MondayApi/Assets/AssetActions.cs)
  - ActivityLogs [CreatedAt](https://developer.monday.com/api-reference/reference/activity-logs#created_at-field) is returned as 17-digit value - this is handled in [UnixDateTimeConverter.cs](/MondayApi/Utils/UnixDateTimeConverter.cs)
  - On updating columns, some columns require specific different JSON property names to update, that is handled by [Utils.convertColumn](/MondayApi/Utils/Utils.cs)

---
This project is meant to be used in two ways:
- Useful helper methods to accomplish most tasks
- Reference code to build your own specific methods
- Also, models for responses to Monday Webhooks are provided in [WebhookResponses](/MondayApi/WebhookResponses)

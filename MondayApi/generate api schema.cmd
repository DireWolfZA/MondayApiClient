@cd %~dp0
graphql-client-generator --serviceUrl "https://api.monday.com/v2" ^
  --outputPath .\Schema ^
  --namespace "MondayApi.Schema" ^
  --outputType OneClassPerFile ^
  --idTypeMapping String ^
  --header "Authorization:%1" ^
  --header "API-Version: 2024-10"

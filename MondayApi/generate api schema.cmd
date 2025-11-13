@cd %~dp0
graphql-client-generator --serviceUrl "https://api.monday.com/v2" ^
  --outputPath .\Schema ^
  --namespace "MondayApi.Schema" ^
  --outputType OneClassPerFile ^
  --idTypeMapping string ^
  --csharpVersion CSharp6 ^
  --nullableReferences true ^
  --header "Authorization:%1" ^
  --header "API-Version: 2025-10"

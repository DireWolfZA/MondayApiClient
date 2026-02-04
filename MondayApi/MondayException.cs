using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GraphQL;

namespace MondayApi {
    public class MondayException : Exception {
        public GraphQLError? ErrorData { get; }
        public MondayException(GraphQLError error, string queryResponse) : base(error.Message) {
            ErrorData = error;
            QueryResponse = queryResponse;
        }

        public Utils.MondayApiError? MondayApiError { get; }
        public string QueryResponse { get; }
        public MondayException(Utils.MondayApiError mondayApiError, string queryResponse) : base(
            mondayApiError.ErrorMessage ??
            mondayApiError.Errors?.FirstOrDefault() ??
            $"{mondayApiError.StatusCode}: {mondayApiError.ErrorCode}"
        ) {
            MondayApiError = mondayApiError;
            QueryResponse = queryResponse;
        }

        public MondayException(string error) : base(error) { QueryResponse = error; } // this is called with queryResponse so save to both

        public override string ToString() {
            if (ErrorData != null || MondayApiError != null) {
                var sb = new StringBuilder();
                string[] str = base.ToString().Split(new[] { Environment.NewLine }, 2, StringSplitOptions.None);
                sb.AppendLine(str[0]);

                var lineData = new List<string>();

                if (ErrorData?.Path?.Count > 0)
                    lineData.Add($"Path: {string.Join(".", ErrorData.Path.Select(p => p.ToString()))}");
                if (ErrorData?.Extensions != null)
                    foreach (var extension in ErrorData.Extensions) {
                        if (extension.Value is IDictionary<string, object> valDict)
                            lineData.Add($"Extension: {extension.Key}: {string.Join(";", valDict.Select(kv => $"{kv.Key}:{kv.Value}"))}");
                        else
                            lineData.Add($"Extension: {extension.Key}: {extension.Value}");
                    }
                if (MondayApiError?.ErrorCode != null)
                    lineData.Add($"Error Code: {MondayApiError.ErrorCode}");
                if (MondayApiError?.StatusCode != null)
                    lineData.Add($"Status Code: {MondayApiError.StatusCode}");
                if (MondayApiError?.ErrorMessage != null)
                    lineData.Add($"Error Message: {MondayApiError.ErrorMessage}");
                if (MondayApiError?.Errors != null && MondayApiError.Errors.Length > 1)
                    lineData.Add($"Errors: {string.Join("; ", MondayApiError.Errors.Skip(1))}");

                if (lineData.Count > 0)
                    sb.AppendLine(string.Join(", ", lineData));

                if (str.Length > 1)
                    sb.Append(str[1]);
                else // remove trailing newline if we don't append base last line of text
                    sb.Remove(sb.Length - 1, 1);
                return sb.ToString();
            } else {
                return base.ToString();
            }
        }

        public static string? GetQueryResponse(AggregateException ex) =>
            ex.Data["Response"]?.ToString() ?? (ex?.InnerException as MondayException)?.QueryResponse;
        public static AggregateException FromErrors(IEnumerable<GraphQLError> errors, string queryResponse) {
            var ex = new AggregateException(errors.Select(e => new MondayException(e, queryResponse)));
            ex.Data["Response"] = queryResponse;
            return ex;
        }
    }
}

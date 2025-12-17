using System;
using System.Collections.Generic;
using System.Linq;
using MondayApi.Schema;

namespace MondayApi.Utils {
    public class Utils {
        // Copied from old version of RestSharp.Validation
        /// <summary>Require a parameter to not be null</summary>
        /// <param name="argumentName">Name of the parameter</param>
        /// <param name="argumentValue">Value of the parameter</param>
        public static void RequireArgument(string? argumentName, [System.Diagnostics.CodeAnalysis.NotNull] object? argumentValue) {
            if (argumentValue == null)
                throw new ArgumentNullException(argumentName);
        }

        public static GraphQlQueryParameter<T>? GetParameter<T>(T? value, bool isNullable = true) =>
            value == null ? null : new GraphQlQueryParameter<T>(null, defaultValue: value, isNullable);
        public static IEnumerable<T>? SkipEmpty<T>(IEnumerable<T?>? values) =>
            values.Where(v => v != null)!;

        private static readonly Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy snakeCaseNamingStrategy = new Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy();
        private static readonly Newtonsoft.Json.JsonSerializerSettings settings = new Newtonsoft.Json.JsonSerializerSettings() {
            ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver() { NamingStrategy = snakeCaseNamingStrategy },
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
        };
        static Utils() => settings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter() { NamingStrategy = snakeCaseNamingStrategy });

        private static object? convertColumn(IColumnValue column) {
            switch (column) {
                case TextValue tv:
                    return tv.Text ?? tv.Value;
                case NumbersValue nv:
                    return nv.Number ?? nv.Text ?? nv.Value;
                case PeopleValue pv:
                    return new PeopleValueForUpdate() {
                        PersonsAndTeams = pv.PersonsAndTeams,
                    };
                case BoardRelationValue bv:
                    return new BoardRelationValueForUpdate() {
                        ItemIDs = bv.LinkedItemIDs,
                    };
                case PhoneValue pv:
                    return new PhoneValueForUpdate() {
                        Phone = pv.Phone,
                        CountryShortName = pv.CountryShortName?.ToUpperInvariant(),
                    };
                case DropdownValue dv:
                    return new DropdownValueForUpdate() {
                        IDs = dv.Values?.Select(v => v.ID).ToList(),
                        Labels = dv.Values?.Select(v => v.Label).ToList(),
                    };
                case CheckboxValue cv:
                    return cv.Checked.HasValue && cv.Checked.Value
                        ? new CheckboxValueForUpdate() { Checked = "true" }
                        : null;
                default:
                    column = column.ShallowCopy();
                    column.ID = null;
                    return column;
            }
        }

        public static string? SerializeColumnValues(IEnumerable<IColumnValue>? columnValues) {
            if (columnValues == null)
                return null;
            var dict = columnValues.ToDictionary<IColumnValue, string?, object?>(column => column.ID, convertColumn);
            return Newtonsoft.Json.JsonConvert.SerializeObject(dict, settings);
        }
        public static string SerializeColumnValue(IColumnValue columnValue) =>
            Newtonsoft.Json.JsonConvert.SerializeObject(convertColumn(columnValue), settings);

        internal static bool TryDeserializeMondayApiError(string response, [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out MondayApiError? mondayApiError) {
            if (string.IsNullOrEmpty(response)) {
                mondayApiError = null;
                return false;
            }
            try {
                mondayApiError = Newtonsoft.Json.JsonConvert.DeserializeObject<MondayApiError>(response, settings)!;
                return true;
            } catch (Newtonsoft.Json.JsonReaderException) {
                mondayApiError = null;
                return false;
            }
        }
    }
}

using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

// adapted from Newtonsoft.Json.Converters.UnixDateTimeConverter
namespace MondayApi.Utils {
    public class UnixDateTimeConverter : DateTimeConverterBase {
        public enum ETimeType {
            Seconds,
            Milliseconds,
            Microseconds,
            SeventeenDigitValue,
        }
        public ETimeType TimeType { get; set; }

        internal static readonly DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);


        public UnixDateTimeConverter() { }
        public UnixDateTimeConverter(ETimeType timeType) => TimeType = timeType;
        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) => throw new NotImplementedException();

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer) {
            bool isNullable = !objectType.IsValueType || (objectType.IsGenericType && objectType.GetGenericTypeDefinition() == typeof(Nullable<>));

            if (isNullable && reader.TokenType == JsonToken.Null)
                return null;
            long timestamp = Convert.ToInt64(reader.Value);

            DateTime rtn;
            switch (TimeType) {
                case ETimeType.Seconds:
                    rtn = unixEpoch.AddSeconds(timestamp);
                    break;
                case ETimeType.Milliseconds:
                    rtn = unixEpoch.AddMilliseconds(timestamp);
                    break;
                case ETimeType.Microseconds:
                    rtn = unixEpoch.AddMilliseconds((double)timestamp / 1000);
                    break;
                case ETimeType.SeventeenDigitValue: // https://developer.monday.com/api-reference/reference/activity-logs#fields
                    rtn = unixEpoch.AddMilliseconds((double)timestamp / 10_000);
                    break;
                default:
                    throw new JsonSerializationException($"Unknown TimeType value: {TimeType}");
            }

            if ((isNullable ? Nullable.GetUnderlyingType(objectType) : objectType) == typeof(DateTimeOffset))
                return new DateTimeOffset(rtn, TimeSpan.Zero);
            else
                return rtn;
        }
    }
}

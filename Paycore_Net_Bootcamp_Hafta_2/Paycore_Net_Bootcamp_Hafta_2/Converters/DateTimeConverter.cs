using System.Text.Json.Serialization;
using System;
using System.Text.Json;

namespace Paycore_Net_Bootcamp_Hafta_2.Converters
{
    /// <summary>
    /// Converts DateTime format to without time
    /// </summary>
    public class DateTimeConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateTime.Parse(reader.GetString());
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToLocalTime().ToString("dd-MM-yyyy"));
        }
    }
}

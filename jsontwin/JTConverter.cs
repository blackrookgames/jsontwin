using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace jsontwin
{
    public class JTConverter : JsonConverter<JTElement>
    {
        #region JsonConverter

        public override JTElement Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var depth = reader.CurrentDepth;
            while (true)
            {
                if (reader.CurrentDepth == depth)
                {
                    reader.Get
                    if (reader.TokenType == JsonTokenType.EndObject) break;
                    if (reader.TokenType == JsonTokenType.EndArray) break;
                }
                Console.WriteLine(new string(' ', reader.CurrentDepth * 2) + reader.TokenType);
                reader.Read();
            }
            return new JTDummy();
        }

        public override void Write(Utf8JsonWriter writer, JTElement value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

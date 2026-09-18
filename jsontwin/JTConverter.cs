using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace jsontwin
{
    public class JTConverter : JsonConverter<JTElement>
    {
        #region 

        private static readonly Dictionary<JsonTokenType, Func<JTElement>> CREATE_FUNCS = new()
        {
            { JsonTokenType.Null, () => new JTNull() },
            { JsonTokenType.String, () => new JTString() },
            { JsonTokenType.Number, () => new JTNumber() },
            { JsonTokenType.True, () => new JTBoolean() },
            { JsonTokenType.False, () => new JTBoolean() },
            { JsonTokenType.StartObject, () => new JTObject() },
            { JsonTokenType.StartArray, () => new JTArray() },
        };

        #endregion

        #region internal methods

        internal static bool MM_TryCreate(JsonTokenType tokenType,
            [MaybeNullWhen(false)] out JTElement created)
        {
            if (CREATE_FUNCS.TryGetValue(tokenType, out var func))
            {
                created = func();
                return true;
            }
            created = null;
            return false;
        }

        #endregion

        #region JsonConverter

        public override JTElement Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (MM_TryCreate(reader.TokenType, out var element))
                element.MM_Load(ref reader, options);
            else
                element = new JTObject();
            return element;
        }

        public override void Write(Utf8JsonWriter writer, JTElement value, JsonSerializerOptions options)
        {
            value.MM_Save(writer, options);
        }

        #endregion
    }
}

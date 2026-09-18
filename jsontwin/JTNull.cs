using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace jsontwin
{
    /// <summary>Represents a JSON null element</summary>
    public class JTNull : JTElement
    {
        #region JTElement

        internal override void MM_Load(ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            reader.Read();
        }

        internal override void MM_Save(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            writer.WriteNullValue();
        }

        #endregion
    }
}

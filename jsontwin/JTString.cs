using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace jsontwin
{
    /// <summary>Represents a JSON string element</summary>
    public class JTString : JTElement
    {
        #region init

        /// <summary>Initializer for <see cref="JTString"/></summary>
        public JTString() : this("")
        { }

        /// <summary>Initializer for <see cref="JTString"/></summary>
        /// <param name="value">String value</param>
        public JTString(string? value) : base()
        {
            f_Value = value;
        }

        #endregion

        #region fields

        private string? f_Value;

        #endregion

        #region properties

        /// <summary>String value</summary>
        public string? Value
        {
            get => f_Value;
            set => f_Value = value;
        }

        #endregion

        #region JTElement

        internal override void MM_Load(ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            void reset() => f_Value = "";
            reset();
            try
            {
                if (reader.TokenType == JsonTokenType.String)
                {
                    f_Value = reader.GetString();
                    reader.Read();
                }
            }
            catch
            {
                reset();
                throw;
            }
        }

        internal override void MM_Save(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            writer.WriteStringValue((f_Value is null) ? "" : f_Value);
        }

        #endregion
    }
}

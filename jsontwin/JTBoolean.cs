using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace jsontwin
{
    /// <summary>Represents a JSON boolean element</summary>
    public class JTBoolean : JTElement
    {
        #region init

        /// <summary>Initializer for <see cref="JTBoolean"/></summary>
        public JTBoolean() : this(default)
        { }

        /// <summary>Initializer for <see cref="JTBoolean"/></summary>
        /// <param name="value">Boolean value</param>
        public JTBoolean(bool value) : base()
        {
            f_Value = value;
        }

        #endregion

        #region fields

        private bool f_Value = default;

        #endregion

        #region properties

        /// <summary>Boolean value</summary>
        public bool Value
        {
            get => f_Value;
            set => f_Value = value;
        }

        #endregion

        #region JTElement

        internal override void MM_Load(ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            void reset() => f_Value = default;
            reset();
            try
            {
                if (reader.TokenType == JsonTokenType.True)
                {
                    f_Value = true;
                    reader.Read();
                }
                else if (reader.TokenType == JsonTokenType.False)
                {
                    f_Value = false;
                    reader.Read();
                }
                else
                {
                    reset();
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
            writer.WriteBooleanValue(f_Value);
        }

        #endregion
    }
}

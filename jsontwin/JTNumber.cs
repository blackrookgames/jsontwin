using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace jsontwin
{
    /// <summary>Represents a JSON number element</summary>
    public class JTNumber : JTElement
    {
        #region init

        /// <summary>Initializer for <see cref="JTNumber"/></summary>
        public JTNumber() : this(default)
        { }

        /// <summary>Initializer for <see cref="JTNumber"/></summary>
        /// <param name="value">Number value</param>
        public JTNumber(decimal value) : base()
        {
            f_Value = value;
        }

        #endregion

        #region fields

        private decimal f_Value;

        #endregion

        #region properties

        /// <summary>Number value</summary>
        public decimal Value
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
                if (reader.TokenType == JsonTokenType.Number)
                {
                    f_Value = reader.GetDecimal();
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
            writer.WriteNumberValue(f_Value);
        }

        #endregion
    }
}

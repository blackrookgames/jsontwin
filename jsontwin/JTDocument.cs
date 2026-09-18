using System;
using System.IO;
using System.Text;
using System.Text.Json;
using CallArgExpAttribute = System.Runtime.CompilerServices.CallerArgumentExpressionAttribute;

namespace jsontwin
{
    /// <summary>Represents a JSON document</summary>
    public class JTDocument
    {
        #region load/save

        private static void MM_ThrowIfCantRead(Stream s,
            [CallArgExp(nameof(s))] string? sParam = null)
        {
            try
            {
                if (s.CanRead) return;
                throw new ArgumentException("Stream does not support reading.", sParam);
            }
            catch when (s is null)
            { throw new ArgumentNullException(sParam); }
        }

        private static void MM_ThrowIfCantWrite(Stream s,
            [CallArgExp(nameof(s))] string? sParam = null)
        {
            try
            {
                if (s.CanWrite) return;
                throw new ArgumentException("Stream does not support writing.", sParam);
            }
            catch when (s is null)
            { throw new ArgumentNullException(sParam); }
        }

        private void MM_Load(StreamReader sr,
            [CallArgExp(nameof(sr))] string? srParam = null)
        {
            try
            { LoadFromString(sr.ReadToEnd()); }
            catch when (sr is null)
            { throw new ArgumentNullException(srParam); }
            catch (OutOfMemoryException)
            { throw new OutOfMemoryException("Memory is insufficient."); }
        }

        private void MM_Save(StreamWriter sw,
            [CallArgExp(nameof(sw))] string? swParam = null)
        {
            try
            {
                sw.Write(SaveToString());
            }
            catch when (sw is null)
            {
                throw new ArgumentNullException(swParam);
            }
        }

        /// <summary>Loads JSON data from the specified stream</summary>
        /// <param name="s">Stream to load from</param>
        /// <param name="encoding">Character encoding</param>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="s"/> is null
        /// </exception>
        /// <exception cref="ArgumentException">
        ///     <paramref name="s"/> does not support reading
        /// </exception>
        /// <exception cref="OutOfMemoryException">
        ///     Insufficient memory
        /// </exception>
        /// <exception cref="IOException">
        ///     I/O error occurred
        /// </exception>
        /// <exception cref="JTException">
        ///     <paramref name="s"/> does not contain valid JSON
        /// </exception>
        public void Load(Stream s, Encoding? encoding = null)
        {
            MM_ThrowIfCantRead(s);
            using StreamReader sr = (encoding is null) ? new(s) : new(s, encoding);
            MM_Load(sr);
        }

        /// <inheritdoc cref="Load(Stream, Encoding)"/>
        /// <param name="detectEncodingFromByteOrderMarks">
        ///     Whether or not to look for byte order marks at beginning
        /// </param>
        public void Load(Stream s, bool detectEncodingFromByteOrderMarks, Encoding? encoding = null)
        {
            MM_ThrowIfCantRead(s);
            using StreamReader sr = (encoding is null) ? 
                new(s, detectEncodingFromByteOrderMarks) :
                new(s, encoding, detectEncodingFromByteOrderMarks);
            MM_Load(sr);
        }

        /// <summary>Saves JSON data to the specified stream</summary>
        /// <param name="s">Stream to save to</param>
        /// <param name="encoding">Character encoding</param>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="s"/> is null
        /// </exception>
        /// <exception cref="ArgumentException">
        ///     <paramref name="s"/> does not support writing
        /// </exception>
        /// <exception cref="IOException">
        ///     I/O error occurred
        /// </exception>
        public void Save(Stream s, Encoding? encoding = null)
        {
            MM_ThrowIfCantWrite(s);
            using StreamWriter sw = (encoding is null) ? new(s) : new(s, encoding);
            MM_Save(sw);
        }

        /// <summary>Loads JSON data from the specified string</summary>
        /// <param name="s">String to load from</param>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="s"/> is null
        /// </exception>
        /// <exception cref="JTException">
        ///     <paramref name="s"/> is not valid JSON
        /// </exception>
        public void LoadFromString(string s)
        {
            ArgumentNullException.ThrowIfNull(s);
            JTElement? root;
            try
            { root = JsonSerializer.Deserialize<JTElement>(s); }
            catch (JsonException e)
            { throw new JTException(e.Message); }
            RootElement = root; // Set the property, NOT the field
        }

        /// <summary>Saves JSON data to a string</summary>
        /// <return>Created string</return>
        public string SaveToString()
        {
            if (f_RootElement is null)
                return JsonSerializer.Serialize<JTElement>(new JTObject());
            return JsonSerializer.Serialize(f_RootElement);
        }

        #endregion

        #region fields

        private JTElement? f_RootElement;
        
        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the root element
        /// </summary>
        /// <exception cref="ArgumentException">
        ///     Value is already part of a document
        /// </exception>
        public JTElement? RootElement
        {
            get => f_RootElement;
            set
            {
                if (f_RootElement == value) return;
                // Make sure element is valid
                if (value is not null && value.Document is not null)
                    throw new ArgumentException("Element cannot already be part of a document.");
                // Set root element
                var prev = f_RootElement;
                f_RootElement = value;
                prev?.MM_SetDocument(null);
                f_RootElement?.MM_SetDocument(this);
            }
        }

        #endregion
    }
}

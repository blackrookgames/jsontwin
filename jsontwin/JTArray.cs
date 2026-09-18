using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace jsontwin
{
    /// <summary>Represents a JSON array element</summary>
    public class JTArray : JTParent, IReadOnlyList<JTElement>
    {
        #region methods

        /// <summary>Ensures the capacity is at least the specified minimum</summary>
        /// <param name="capacity">Minimum capacity</param>
        /// <returns>Adjusted capacity</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     <paramref name="capacity"/> is negative 
        /// </exception>
        public int EnsureCapacity(int capacity)
        {
            return MM_EnsureCapacity(capacity);
        }

        /// <summary>Sets the capacity to the actual number of child elements</summary>
        public void TrimExcess()
        {
            MM_TrimExcess();
        }

        /// <summary>Attempts to add the specified element to the array</summary>
        /// <param name="element">Element to add</param>
        /// <returns>Whether or not successful</returns>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="element"/> is null 
        /// </exception>
        public bool TryAdd(JTElement element)
        {
            return MM_TryAdd(element);
        }

        /// <summary>Attempts to insert the specified element into the array</summary>
        /// <param name="index">Insertion index</param>
        /// <param name="element">Element to insert</param>
        /// <returns>Whether or not successful</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     <paramref name="index"/> is out of range
        /// </exception>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="element"/> is null 
        /// </exception>
        public bool TryInsert(int index, JTElement element)
        {
            return MM_TryInsert(index, element);
        }

        /// <summary>Removes the element at the specified index from the array</summary>
        /// <param name="index">Index of element to remove</param>
        /// <returns>Removed element</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     <paramref name="index"/> is out of range
        /// </exception>
        public JTElement RemoveAt(int index)
        {
            return MM_RemoveAt(index);
        }

        /// <summary>Removes all elements from the array</summary>
        public void Clear()
        {
            while (Count > 0) RemoveAt(Count - 1);
        }

        #endregion

        #region JTElement

        internal override void MM_Load(ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            void reset()
            {
                Clear();
                TrimExcess();
            }
            reset();
            try
            {
                if (reader.TokenType == JsonTokenType.StartArray)
                {
                    reader.Read();
                    while (reader.TokenType != JsonTokenType.EndArray)
                    {
                        if (JTConverter.MM_TryCreate(reader.TokenType, out var element))
                        {
                            element.MM_Load(ref reader, options);
                            TryAdd(element);
                        }
                        else
                        {
                            reader.Read();
                        }
                    }
                    // Go to end
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
            writer.WriteStartArray();
            for (int i = 0; i < Count; ++i)
                Get(i).MM_Save(writer, options);
            writer.WriteEndArray();
        }

        #endregion

        #region IReadOnlyList

        /// <summary>Gets the element at the specified index</summary>
        /// <param name="index">Index of element</param>
        /// <returns>Element at the specified index</returns>
        /// <exception cref="IndexOutOfRangeException">
        ///     <paramref name="index"/> is out of range 
        /// </exception>
        public JTElement this[int index]
        {
            get
            {
                try
                { return Get(index); }
                catch when (index < 0 || index >= Count)
                { throw new IndexOutOfRangeException(); }
            }
        }

        /// <summary>Gets an enumerator thru the array elements</summary>
        /// <returns>Enumerator thru the array elements</returns>
        public IEnumerator<JTElement> GetEnumerator() => MM_GetEnumerator();

        int IReadOnlyCollection<JTElement>.Count => Count;

        IEnumerator IEnumerable.GetEnumerator() => MM_GetEnumerator();

        #endregion
    }
}

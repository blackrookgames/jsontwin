using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace jsontwin
{
    /// <summary>Represents a JSON object element</summary>
    public class JTObject : JTParent, IReadOnlyList<JTObjectProperty>
    {
        #region init

        public JTObject()
        {
            f_Properties = new(Capacity);
        }

        #endregion
        
        #region fields

        private readonly List<JTObjectProperty> f_Properties;

        #endregion

        #region methods

        /// <summary>Ensures the capacity is at least the specified minimum</summary>
        /// <param name="capacity">Minimum capacity</param>
        /// <returns>Adjusted capacity</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     <paramref name="capacity"/> is negative 
        /// </exception>
        public int EnsureCapacity(int capacity)
        {
            int newCapacity = MM_EnsureCapacity(capacity);
            f_Properties.EnsureCapacity(capacity);
            return newCapacity;
        }

        /// <summary>Sets the capacity to the actual number of child elements</summary>
        public void TrimExcess()
        {
            MM_TrimExcess();
            f_Properties.TrimExcess();
        }

        /// <summary>Attempts to add the specified property to the object</summary>
        /// <param name="name">Property name</param>
        /// <param name="element">Property element</param>
        /// <returns>Whether or not successful</returns>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="name"/> is null
        ///     <br/>or<br/>
        ///     <paramref name="element"/> is null 
        /// </exception>
        public bool TryAdd(string name, JTElement element)
        {
            ArgumentNullException.ThrowIfNull(name);
            if (!MM_TryAdd(element)) return false;
            f_Properties.Add(new(name, element));
            return true;
        }

        /// <summary>Attempts to insert the specified property into the object</summary>
        /// <param name="index">Insertion index</param>
        /// <param name="name">Property name</param>
        /// <param name="element">Property element</param>
        /// <returns>Whether or not successful</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     <paramref name="index"/> is out of range
        /// </exception>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="name"/> is null
        ///     <br/>or<br/>
        ///     <paramref name="element"/> is null 
        /// </exception>
        public bool TryInsert(int index, string name, JTElement element)
        {
            if (index < 0 || index > Count)
                throw new ArgumentOutOfRangeException(nameof(index));
            ArgumentNullException.ThrowIfNull(name);
            if (!MM_TryInsert(index, element)) return false;
            f_Properties.Insert(index, new(name, element));
            return true;
        }

        /// <summary>Removes the property at the specified index from the object</summary>
        /// <param name="index">Index of property to remove</param>
        /// <returns>Removed property</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     <paramref name="index"/> is out of range
        /// </exception>
        public JTObjectProperty RemoveAt(int index)
        {
            MM_RemoveAt(index);
            var property = f_Properties[index];
            f_Properties.RemoveAt(index);
            return property;
        }

        /// <summary>Removes all properties from the object</summary>
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
                if (reader.TokenType == JsonTokenType.StartObject)
                {
                    reader.Read();
                    while (reader.TokenType != JsonTokenType.EndObject)
                    {
                        // Read property name
                        string propertyName = "";
                        if (reader.TokenType == JsonTokenType.PropertyName)
                        {
                            propertyName = $"{reader.GetString()}";
                            reader.Read();
                        }
                        // Read property element
                        JTElement propertyElement;
                        while (true)
                        {
                            if (reader.TokenType != JsonTokenType.EndObject)
                            {
                                if (JTConverter.MM_TryCreate(reader.TokenType, out propertyElement!))
                                {
                                    propertyElement.MM_Load(ref reader, options);
                                    break;
                                }
                                reader.Read();
                            }
                            else
                            {
                                propertyElement = new JTNull();
                                break;
                            }
                        }
                        // Add property
                        TryAdd(propertyName, propertyElement);
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
            writer.WriteStartObject();
            foreach (var property in f_Properties)
            {
                writer.WritePropertyName(property.Name);
                property.Element.MM_Save(writer, options);
            }
            writer.WriteEndObject();
        }

        #endregion

        #region IReadOnlyList

        /// <summary>Gets the property at the specified index</summary>
        /// <param name="index">Index of property</param>
        /// <returns>Property at the specified index</returns>
        /// <exception cref="IndexOutOfRangeException">
        ///     <paramref name="index"/> is out of range 
        /// </exception>
        public JTObjectProperty this[int index]
        {
            get
            {
                try
                { return f_Properties[index]; }
                catch when (index < 0 || index >= f_Properties.Count)
                { throw new IndexOutOfRangeException(); }
            }
        }

        /// <summary>Gets an enumerator thru the object properties</summary>
        /// <returns>Enumerator thru the object properties</returns>
        public IEnumerator<JTObjectProperty> GetEnumerator() => f_Properties.GetEnumerator();

        int IReadOnlyCollection<JTObjectProperty>.Count => Count;

        IEnumerator IEnumerable.GetEnumerator() => f_Properties.GetEnumerator();

        #endregion
    }
}

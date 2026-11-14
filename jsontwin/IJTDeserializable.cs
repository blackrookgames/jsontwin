using System;

namespace jsontwin
{
    /// <summary>Represents object data that can be deserialized from JSON data</summary>
    /// <typeparam name="TElement">Input JSON element type</typeparam>
    public interface IJTDeserializable<TElement>
        where TElement: JTElement
    {
        /// <summary>Deserializes JSON data</summary>
        /// <param name="input">Input element</param>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="input"/> is null
        /// </exception>
        /// <exception cref="JTException">
        ///     <paramref name="input"/> contains invalid data
        /// </exception>
        public void Deserialize(TElement input);
    }
}
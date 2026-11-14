using System;

namespace jsontwin
{
    /// <summary>Represents object data that can be serialized into JSON data</summary>
    /// <typeparam name="TElement">Output JSON element type</typeparam>
    public interface IJTSerializable<TElement>
        where TElement: JTElement
    {
        /// <summary>Serializes the object's data</summary>
        /// <param name="output">Output element</param>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="output"/> is null
        /// </exception>
        public void Serialize(TElement output);
    }
}
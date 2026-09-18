using System;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace jsontwin
{
    /// <summary>Represents a JSON element</summary>
    [JsonConverter(typeof(JTConverter))]
    public abstract class JTElement
    {
        #region init

        private protected JTElement() { }

        #endregion
        
        #region fields

        private JTDocument? f_Document;
        private JTParent? f_Parent;
        private int f_Index;

        #endregion

        #region properties

        /// <summary>Document</summary>
        public JTDocument? Document => f_Document;

        /// <summary>Parent element</summary>
        public JTParent? Parent => f_Parent;

        /// <summary>Index in parent; meaningless if element does not have a parent</summary>
        public int Index => f_Index;

        #endregion

        #region protected methods

        private protected virtual void MM_DocRefUpdated() { }

        #endregion

        #region internal methods

        internal abstract void MM_Load(ref Utf8JsonReader reader, JsonSerializerOptions options);

        internal abstract void MM_Save(Utf8JsonWriter writer, JsonSerializerOptions options);

        /// <remarks>
        ///     Also accessed by
        ///     <br/>- <see cref="JTDocument"/>
        ///     <br/>- <see cref="JTParent"/>
        /// </remarks>
        internal void MM_SetDocument(JTDocument? document)
        {
            if (f_Document == document) return;
            f_Document = document;
            MM_DocRefUpdated();
        }

        /// <remarks>
        ///     Assume
        ///     <br/>- <paramref name="parent"/> is not null
        ///     <br/><br/>
        ///     Also accessed by <see cref="JTParent"/>
        /// </remarks>
        internal void MM_GetOwned(JTParent parent, int index)
        {
            MM_SetDocument(parent.Document);
            f_Parent = parent;
            f_Index = index;
        }

        /// <remarks>Also accessed by <see cref="JTParent"/></remarks>
        internal void MM_GetDisowned()
        {
            MM_SetDocument(null);
            f_Parent = null;
            f_Index = -1;
        }

        #endregion

        #region utility

        /// <summary>Casts the current element as an instance of <typeparamref name="T"/></summary>
        /// <returns>Current element casted as an instance of <typeparamref name="T"/></returns>
        /// <exception cref="JTException">
        ///     Current element is not an instance of <typeparamref name="T"/>
        /// </exception>
        public T CastAs<T>() where T: JTElement
        {
            if (this is not T casted)
            {
                string? desc = null;
                try
                {
                    JTElementAttribute? attr = typeof(T).GetCustomAttribute<JTElementAttribute>();
                    if (attr is not null)
                    {
                        desc = attr.Desc;
                    }
                }
                catch { }
                desc ??= typeof(T).Name;
                throw new JTException(this, $"Expected {desc}.");
            }
            return casted;
        }

        #endregion
    }
}

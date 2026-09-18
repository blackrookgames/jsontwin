using System;
using System.Collections;
using System.Collections.Generic;
using CallArgExpAttribute = System.Runtime.CompilerServices.CallerArgumentExpressionAttribute;

namespace jsontwin
{
    /// <summary>Represents a JSON object property</summary>
    public readonly struct JTObjectProperty
    {
        #region init

        /// <remarks>
        ///     Assume
        ///     <br/>- <paramref name="name"/> is not null
        ///     <br/>- <paramref name="element"/> is not null
        ///     <br/><br/>
        ///     Also accessed by <see cref="JTObject"/>
        /// </remarks>
        internal JTObjectProperty(string name, JTElement element)
        {
            f_Name = name;
            f_Element = element;
        }

        #endregion

        #region fields

        private readonly string f_Name;
        private readonly JTElement f_Element;

        #endregion

        #region properties

        /// <summary>Property name</summary>
        public string Name => f_Name;

        /// <summary>Property element</summary>
        public JTElement Element => f_Element;

        #endregion
    }
}

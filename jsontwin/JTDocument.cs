using System;

namespace jsontwin
{
    public class JTDocument
    {
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

using System;
using System.Collections.Generic;
using System.IO;

namespace jsontwin
{
    /// <summary>Thrown when a JSON related error occurs</summary>
    public class JTException : Exception
    {
        #region init

        /// <summary>Initializer for <see cref="JTException"/></summary>
        /// <param name="message">Message</param>
        public JTException(string? message) :
            this(null, message)
        { }

        /// <summary>Initializer for <see cref="JTException"/></summary>
        /// <param name="element">Related JSON element</param>
        /// <param name="message">Base message</param>
        public JTException(JTElement? element, string? message) :
            base(CreateMessage(element, message))
        {
            f_Element = element;
            f_BaseMessage = message;
        }

        #endregion

        #region fields

        private readonly JTElement? f_Element;
        private readonly string? f_BaseMessage;

        #endregion
        
        #region properties

        /// <summary>Related JSON element</summary>
        public JTElement? Element => f_Element;

        /// <summary>Base message</summary>
        public string? BaseMessage => f_BaseMessage;

        #endregion

        #region private methods

        private static string? CreateMessage(JTElement? element, string? message)
        {
            if (element is not null || message is not null)
            {
                using StringWriter sw = new();
                // Message
                if (message is not null)
                    sw.Write(message);
                // Element
                if (element is not null)
                {
                    List<JTElement> tree = [element];
                    while (true)
                    {
                        element = element!.Parent;
                        if (element is null) break;
                        tree.Add(element);
                    }
                    if (message is not null)
                        sw.Write(' ');
                    for (int i = tree.Count - 2; i >= 0; --i)
                    {
                        element = tree[i];
                        if ((i + 2) < tree.Count)
                            sw.Write('/');
                        if (element.Parent is JTObject obj)
                            sw.Write(obj[element.Index].Name);
                        else
                            sw.Write(element.Index);
                    }
                }
                // Return 
                return sw.ToString();
            }
            return null;
        }

        #endregion
    }
}
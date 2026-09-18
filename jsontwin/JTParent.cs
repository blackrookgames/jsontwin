using System;
using System.Collections.Generic;
using CallArgExpAttribute = System.Runtime.CompilerServices.CallerArgumentExpressionAttribute;

namespace jsontwin
{
    /// <summary>Represents a JSON parent element</summary>
    public abstract class JTParent : JTElement
    {
        #region init

        private protected JTParent()
        {
            f_Children = [];
        }

        #endregion
        
        #region fields

        private readonly List<JTElement> f_Children;

        #endregion

        #region properties

        /// <summary>Number of child elements internal data structure can hold without resizing</summary>
        public int Capacity => f_Children.Capacity;

        /// <summary>Number of child elements</summary>
        public int Count => f_Children.Count;

        #endregion

        #region private methods

        private bool MM_CanAdd(JTElement element,
            [CallArgExp(nameof(element))] string? elementParam = null)
        {
            try
            {
                // Make sure element doesn't already have a parent
                if (element.Parent is not null) return false;
                // Make sure element isn't already part of a document
                if (element.Document is not null) return false;
                // Make sure element isn't an ancestor to the current parent (preventing circular ancestry)
                var ancestor = Parent;
                while (ancestor is not null)
                {
                    if (ancestor == element) return false;
                    ancestor = ancestor.Parent;
                }
                // Yes!!!
                return true;
            }
            catch when (element is null)
            {
                throw new ArgumentNullException(elementParam);
            }
        }

        #endregion

        #region protected methods

        private protected IEnumerator<JTElement> MM_GetEnumerator()
        {
            return f_Children.GetEnumerator();
        }

        private protected int MM_EnsureCapacity(int capacity,
            [CallArgExp(nameof(capacity))] string? capacityParam = null)
        {
            if (capacity >= 0) return f_Children.EnsureCapacity(capacity);
            throw new ArgumentOutOfRangeException(capacityParam, "Value cannot be negative.");
        }

        private protected void MM_TrimExcess()
        {
            f_Children.TrimExcess();
        } 

        private protected bool MM_TryAdd(JTElement element,
            [CallArgExp(nameof(element))] string? elementParam = null)
        {
            if (!MM_CanAdd(element, elementParam: elementParam))
                return false;
            element.MM_GetOwned(this, f_Children.Count);
            f_Children.Add(element);
            return true;
        }

        private protected bool MM_TryInsert(int index, JTElement element,
            [CallArgExp(nameof(index))] string? indexParam = null,
            [CallArgExp(nameof(element))] string? elementParam = null)
        {
            if (index < 0 || index > f_Children.Count)
                throw new ArgumentOutOfRangeException(indexParam);
            if (!MM_CanAdd(element, elementParam: elementParam))
                return false;
            element.MM_GetOwned(this, f_Children.Count);
            f_Children.Insert(index, element);
            return true;
        }

        private protected JTElement MM_RemoveAt(int index,
            [CallArgExp(nameof(index))] string? indexParam = null)
        {
            if (index < 0 || index >= f_Children.Count)
                throw new ArgumentOutOfRangeException(indexParam);
            var removedChild = f_Children[index];
            f_Children.RemoveAt(index);
            removedChild.MM_GetDisowned();
            return removedChild;
        }

        #endregion

        #region methods

        /// <summary>Gets the child element at the specified index</summary>
        /// <param name="index">Index of child element</param>
        /// <returns>Child element at the specified index</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     <paramref name="index"/> is out of range
        /// </exception>
        public JTElement Get(int index)
        {
            try
            {
                return f_Children[index];
            }
            catch when (index < 0 || index >= f_Children.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
        }

        #endregion

        #region JTElement

        private protected override void MM_DocRefUpdated()
        {
            base.MM_DocRefUpdated();
            foreach (var child in f_Children)
                child.MM_SetDocument(Document);
        }

        #endregion
    }
}

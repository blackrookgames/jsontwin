using System;

namespace jsontwin
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal class JTElementAttribute : Attribute
    {
        public string? Desc;
    }
}

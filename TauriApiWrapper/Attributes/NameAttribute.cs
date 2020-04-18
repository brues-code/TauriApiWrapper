using System;

namespace TauriApiWrapper.Enums
{
    internal class NameAttribute : Attribute
    {
        internal string Name { get; private set; }

        internal NameAttribute(string name)
        {
            Name = name;
        }
    }
}
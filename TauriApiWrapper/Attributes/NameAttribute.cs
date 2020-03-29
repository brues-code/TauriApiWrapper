using System;

namespace TauriApiWrapper.Enums
{
    internal class NameAttribute : Attribute
    {
        internal string Name { get; private set; }

        public NameAttribute(string name)
        {
            Name = name;
        }
    }
}
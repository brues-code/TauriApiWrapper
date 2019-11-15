using System;

namespace Tauri_SDK.Enums
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
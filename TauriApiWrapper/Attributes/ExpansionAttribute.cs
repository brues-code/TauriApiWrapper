using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Attributes
{
    [System.AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = true)]
    internal sealed class ExpansionAttribute : Attribute
    {
        public ExpansionAttribute(Expansion expansion)
        {
            Expansion = expansion;
        }

        public Expansion Expansion { get; }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Attributes
{
    [System.AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = true)]
    internal sealed class LinkedRealmAttribute : Attribute
    {
        public LinkedRealmAttribute(Realm masterRealm)
        {
            MasterRealm = masterRealm;
        }

        public Realm MasterRealm { get; }
    }
}
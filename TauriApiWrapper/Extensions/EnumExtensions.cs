using System;
using TauriApiWrapper.Attributes;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Extensions
{
    internal static class EnumExtensions
    {
        internal static string ToName(this Enum val)
        {
            NameAttribute[] attributes = (NameAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(NameAttribute), false);
            return attributes.Length > 0 ? attributes[0].Name : string.Empty;
        }

        internal static Realm ToMasterRealm(this Enum val)
        {
            LinkedRealmAttribute[] attributes = (LinkedRealmAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(LinkedRealmAttribute), false);
            return (Realm)(attributes.Length > 0 ? attributes[0].MasterRealm : val);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Attributes
{
    public static class EnumAttributes
    {
        public static string ToName(this Enum val)
        {
            NameAttribute[] attributes = (NameAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Name : string.Empty;
        }
    }
}
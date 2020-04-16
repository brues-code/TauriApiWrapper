using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal sealed class RaidMapRequest : BaseRequestObject
    {
        public RaidMapRequest(Realm realm) : base(realm)
        {
        }
    }
}
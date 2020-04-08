using System;
using System.Collections.Generic;
using System.Text;

namespace TauriApiWrapper.Objects.Responses
{
    public sealed class ItemResponseList : ItemResponseBase
    {
        public Dictionary<int, ItemResponse> Items { get; set; }
    }
}
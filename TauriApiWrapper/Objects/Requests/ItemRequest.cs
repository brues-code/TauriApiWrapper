using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TauriApiWrapper.Attributes;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    public class ItemRequest : BaseRequestObject
    {
        public ItemRequest(int itemID, Realm realm = Realm.Evermoon) : base(realm)
        {
            ItemID = itemID;
        }

        [JsonProperty("e")]
        public int ItemID { get; }
    }
}
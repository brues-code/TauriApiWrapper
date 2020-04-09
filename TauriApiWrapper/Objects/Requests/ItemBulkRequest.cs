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
    public class ItemBulkRequest : BaseRequestObject
    {
        public ItemBulkRequest(IEnumerable<int> itemIds, Realm realm = Realm.Evermoon) : base(realm)
        {
            ItemIDs = itemIds;
        }

        [JsonProperty("e")]
        public IEnumerable<int> ItemIDs { get; }
    }
}
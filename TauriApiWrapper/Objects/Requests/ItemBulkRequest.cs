using Newtonsoft.Json;
using System.Collections.Generic;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal sealed class ItemBulkRequest : BaseRequestObject
    {
        public ItemBulkRequest(IEnumerable<int> itemIds, Realm realm = Realm.Evermoon) : base(realm)
        {
            ItemIDs = itemIds;
        }

        [JsonProperty("e")]
        public IEnumerable<int> ItemIDs { get; }
    }
}
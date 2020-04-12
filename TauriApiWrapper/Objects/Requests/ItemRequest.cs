using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    public class ItemRequest : BaseRequestObject
    {
        public ItemRequest(int itemID, Realm realm = Realm.Evermoon) : base(realm)
        {
            ItemID = itemID.ToString();
        }

        public ItemRequest(string guid, Realm realm) : base(realm)
        {
            ItemID = guid.ToString();
        }

        [JsonProperty("e")]
        public string ItemID { get; }
    }
}
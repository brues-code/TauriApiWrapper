using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal sealed class ItemRequest : BaseRequestObject
    {
        public ItemRequest(int itemID, Realm realm = Realm.Evermoon) : base(realm)
        {
            ItemID = itemID.ToString();
        }

        public ItemRequest(string guid, Realm realm) : base(realm)
        {
            ItemGuid = guid;
        }

        [JsonProperty("e")]
        public string ItemID { get; }

        [JsonProperty("i")]
        public string ItemGuid { get; }
    }
}
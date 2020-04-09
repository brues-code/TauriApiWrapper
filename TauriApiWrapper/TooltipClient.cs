using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses;

namespace TauriApiWrapper
{
    public class TooltipClient : TauriClient
    {
        private const string _url = "item-tooltip";

        public TooltipClient(string apiKey, string secret) : base(apiKey, secret)
        {
        }

        /// <summary>
        /// Returns an items, without enchants/gems
        /// </summary>
        /// <param name="id">ID of the Item</param>
        /// <param name="realm">Realm to search on. Default is <see cref="Realm.Evermoon"/></param>
        public ApiResponse<ItemResponse> GetItemById(int id, Realm realm = Realm.Evermoon)
        {
            ApiParams param = new ApiParams(_url, Secret, new ItemRequest(id, realm));
            return Communicate<ItemResponse>(param);
        }

        /// <summary>
        /// Returns a list of items, without enchants/gems
        /// </summary>
        /// <param name="itemIds">Ids of the items you want to search for</param>
        /// <param name="realm">Realm to search on. Default is <see cref="Realm.Evermoon"/></param>
        public ApiResponse<List<ItemResponse>> GetItemsByIds(IEnumerable<int> itemIds, Realm realm = Realm.Evermoon)
        {
            ApiParams param = new ApiParams(_url, Secret, new ItemBulkRequest(itemIds, realm));

            ApiResponse<JObject> apiItems = Communicate<JObject>(param);
            List<ItemResponse> items = new List<ItemResponse>();
            List<string> comparerKeys = itemIds.Select(x => x.ToString()).ToList();
            foreach (KeyValuePair<string, JToken> item in apiItems.Response)
            {
                if (!comparerKeys.Contains(item.Key))
                    continue;

                items.Add(item.Value.ToObject<ItemResponse>());
            }

            ApiResponse<List<ItemResponse>> sanitizedResponse = new ApiResponse<List<ItemResponse>>()
            {
                ErrorCode = apiItems.ErrorCode,
                ErrorMessage = apiItems.ErrorMessage,
                IsSuccess = apiItems.IsSuccess,
                Response = items
            };

            return sanitizedResponse;
        }

        /// <summary>
        /// Gets an item holded by the player, with all the data it should contain such as enchants and gems
        /// </summary>
        /// <param name="guid">Guid of the player's item</param>
        /// <param name="realm">Realm to search on. Default is <see cref="Realm.Evermoon"/></param>
        public ApiResponse<ItemResponse> GetItemByGuid(string guid, Realm realm = Realm.Evermoon)
        {
            ApiParams param = new ApiParams(_url, Secret, new ItemRequest(guid, realm));
            return Communicate<ItemResponse>(param);
        }
    }
}
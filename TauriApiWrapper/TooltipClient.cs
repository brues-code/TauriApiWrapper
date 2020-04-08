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
        /// TODO: Change return type later
        /// </summary>
        public ApiResponse<ItemResponse> GetItemById(int id, Realm realm = Realm.Evermoon)
        {
            ApiParams param = new ApiParams(_url, Secret, new ItemRequest(id, realm));
            return Communicate<ItemResponse>(param);
        }

        /// <summary>
        /// TODO: Change return type later
        /// </summary>
        public ApiResponse<ItemResponseList> GetItemsByIds(IEnumerable<int> itemIds, Realm realm = Realm.Evermoon)
        {
            ApiParams param = new ApiParams(_url, Secret, new ItemRequest(itemIds, realm));
            return Communicate<ItemResponseList>(param);
        }
    }
}
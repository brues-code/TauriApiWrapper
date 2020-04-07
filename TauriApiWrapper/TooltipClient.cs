using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;

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
        public ApiResponse<object> GetItemById(int id, Realm realm = Realm.Evermoon)
        {
            var param = new ApiParams(_url, Secret, new ItemRequest(id, realm));
            return Communicate<object>(param);
        }

        /// <summary>
        /// TODO: Change return type later
        /// </summary>
        public void GetItemsByIds(params int[] ids)
        {
        }
    }
}
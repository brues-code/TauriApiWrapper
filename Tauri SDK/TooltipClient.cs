using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tauri_SDK
{
    public class TooltipClient : TauriClient
    {
        public TooltipClient(string apiKey, string secret) : base(apiKey, secret)
        {
        }

        /// <summary>
        /// TODO: Change return type later
        /// </summary>
        public void GetItemById(int id)
        {

        }

        /// <summary>
        /// TODO: Change return type later
        /// </summary>
        public void GetItemsById(params int[] ids)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TauriApiWrapper.Attributes;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Items
{
    public class ItemRequest : IApiParam
    {
        private Realm _realm;

        public ItemRequest(Realm realm, int itemID)
        {
            _realm = realm;
            ItemID = itemID;
        }

        public int ItemID { get; }

        public string Realm => _realm.ToName();
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;

namespace TauriApiWrapper
{
    public class CharacterClient : TauriClient
    {
        private const string _characterTooltipUrl = "item-tooltip";

        public CharacterClient(string apiKey, string secretKey) : base(apiKey, secretKey)
        {
        }

        public ApiResponse<object> GetCharacterByName(string name, Realm realm)
        {
            ApiParams param = new ApiParams(_characterTooltipUrl, Secret, new CharacterRequest(name, realm));
            return Communicate<object>(param);
        }
    }
}
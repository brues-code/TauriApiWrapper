using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses.Character;

namespace TauriApiWrapper
{
    public class CharacterClient : TauriClient
    {
        private const string _characterTooltipUrl = "item-tooltip";
        private const string _characterSheerUrl = "character-sheet";

        public CharacterClient(string apiKey, string secretKey) : base(apiKey, secretKey)
        {
        }

        public ApiResponse<CharacterResponse> GetCharacterTooltipByName(string characterName, Realm realm)
        {
            ApiParams param = new ApiParams(_characterTooltipUrl, Secret, new CharacterRequest(characterName, realm));
            return Communicate<CharacterResponse>(param);
        }

        public ApiResponse<CharacterSheetResponse> GetCharacterSheet(string characterName, Realm realm)
        {
            ApiParams param = new ApiParams(_characterSheerUrl, Secret, new CharacterRequest(characterName, realm));
            return Communicate<CharacterSheetResponse>(param);
        }
    }
}
using System.Threading.Tasks;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses.Character;

namespace TauriApiWrapper
{
    public class CharacterClient : TauriClient
    {
        public CharacterClient(string apiKey, string secretKey) : base(apiKey, secretKey)
        {
        }

        private class Endpoints
        {
            public const string TooltipUrl = "item-tooltip";
            public const string SheetUrl = "character-sheet";
            public const string Talents = "character-talents";
            public const string Reputation = "character-reputation";
            public const string ArenaTeams = "character-arenateams";
        }

        #region Sync

        public ApiResponse<Character> GetCharacterTooltipByName(string characterName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.TooltipUrl, Secret, new CharacterRequest(characterName, realm));
            return Communicate<Character>(param);
        }

        public ApiResponse<CharacterSheet> GetCharacterSheet(string characterName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.TooltipUrl, Secret, new CharacterRequest(characterName, realm));
            return Communicate<CharacterSheet>(param);
        }

        public ApiResponse<CharacterTalents> GetCharacterTalents(string characterName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.Talents, Secret, new CharacterRequest(characterName, realm));
            return Communicate<CharacterTalents>(param);
        }

        public ApiResponse<CharacterReputation> GetCharacterReputation(string characterName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.Reputation, Secret, new CharacterRequest(characterName, realm));
            return Communicate<CharacterReputation>(param);
        }

        #endregion Sync

        #region Async

        public async Task<ApiResponse<Character>> GetCharacterTooltipByNameAsync(string characterName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.TooltipUrl, Secret, new CharacterRequest(characterName, realm));
            return await CommunicateAsync<Character>(param);
        }

        public async Task<ApiResponse<CharacterSheet>> GetCharacterSheetAsync(string characterName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.TooltipUrl, Secret, new CharacterRequest(characterName, realm));
            return await CommunicateAsync<CharacterSheet>(param);
        }

        public async Task<ApiResponse<CharacterTalents>> GetCharacterTalentsAsync(string characterName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.Talents, Secret, new CharacterRequest(characterName, realm));
            return await CommunicateAsync<CharacterTalents>(param);
        }

        public async Task<ApiResponse<CharacterReputation>> GetCharacterReputationAsync(string characterName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.Reputation, Secret, new CharacterRequest(characterName, realm));
            return await CommunicateAsync<CharacterReputation>(param);
        }

        #endregion Async
    }
}
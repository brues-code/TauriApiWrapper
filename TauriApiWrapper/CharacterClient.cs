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

        //public ApiResponse<CharacterReputation> GetCharacterArenaTeams(string characterName, Realm realm)
        //{
        //    ApiParams param = new ApiParams(Endpoints.ArenaTeams, Secret, new CharacterRequest(characterName, realm));
        //    return Communicate<CharacterReputation>(param);
        //}
    }
}
using System.Threading.Tasks;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses.Achievement;

namespace TauriApiWrapper
{
    public class AchievementClient : TauriClient
    {
        private class Endpoints
        {
            public const string AchievementFirsts = "achievement-firsts";
            public const string CharacterAchievements = "character-achievements";
            public const string AchievementsLoader = "achievements-loader";
        }

        public AchievementClient(string apiKey, string secretKey) : base(apiKey, secretKey)
        {
        }

        #region Sync

        public ApiResponse<AchievementFirst> GetAchievementFirsts(Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AchievementFirsts, Secret, new AchievementBaseRequest(realm));
            return Communicate<AchievementFirst>(param);
        }

        public ApiResponse<CharacterAchievements> GetCharacterAchievements(string characterName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.CharacterAchievements, Secret, new CharacterAchievementsRequest(characterName, realm));
            return Communicate<CharacterAchievements>(param);
        }

        public ApiResponse<CharacterAchievementsLoader> GetCharacterAchievementsLoader(string characterName, int categoryId, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AchievementsLoader, Secret, new AchievementsLoaderRequest(characterName, categoryId, realm));
            return Communicate<CharacterAchievementsLoader>(param);
        }

        #endregion Sync

        #region Async

        public async Task<ApiResponse<AchievementFirst>> GetAchievementFirstsAsync(Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AchievementFirsts, Secret, new AchievementBaseRequest(realm));
            return await CommunicateAsync<AchievementFirst>(param);
        }

        public async Task<ApiResponse<CharacterAchievements>> GetCharacterAchievementsAsync(string characterName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.CharacterAchievements, Secret, new CharacterAchievementsRequest(characterName, realm));
            return await CommunicateAsync<CharacterAchievements>(param);
        }

        public async Task<ApiResponse<CharacterAchievementsLoader>> GetCharacterAchievementsLoaderAsync(string characterName, int categoryId, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AchievementsLoader, Secret, new AchievementsLoaderRequest(characterName, categoryId, realm));
            return await CommunicateAsync<CharacterAchievementsLoader>(param);
        }

        #endregion Async
    }
}
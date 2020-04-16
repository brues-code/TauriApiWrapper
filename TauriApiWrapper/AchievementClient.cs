using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses;
using TauriApiWrapper.Objects.Responses.Achievement;

namespace TauriApiWrapper
{
    public class AchievementClient : TauriClient
    {
        private class Endpoints
        {
            public const string AchievementFrists = "achievement-firsts";
            public const string CharacterAchievements = "character-achievements";
            public const string AchievementsLoader = "achievements-loader";
        }
        public AchievementClient(string apiKey, string secretKey) : base(apiKey, secretKey)
        {
        }

        public ApiResponse<AchievementFirst> GetAchievementFrists(Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AchievementFrists, Secret, new AchievementBaseRequest(realm));
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
    }
}

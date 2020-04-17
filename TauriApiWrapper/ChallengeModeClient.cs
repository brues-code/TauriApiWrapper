using System.Threading.Tasks;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses.Challenge;

namespace TauriApiWrapper
{
    public class ChallengeModeClient : TauriClient
    {
        private class Endpoints
        {
            public const string ChallengeIndex = "challenge-index";
            public const string ChallengeLeaderboard = "challenge-leaderboard";
            public const string CaallengeLeaderboardGuild = "challenge-leaderboard-guild"; // same as the ChallengeLeaderboard
        }

        public ChallengeModeClient(string apiKey, string secretKey) : base(apiKey, secretKey)
        {
        }

        #region Sync

        public ApiResponse<ChallengeIndex> GetChallengeIndex(Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.ChallengeIndex, Secret, new ChallengeModeBaseRequest(realm));
            return Communicate<ChallengeIndex>(param);
        }

        public ApiResponse<ChallengeLeaderboard> GetChallengeLeaderboard(int mapId, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.ChallengeLeaderboard, Secret, new ChallengeModeLeaderboardRequest(mapId, realm));
            return Communicate<ChallengeLeaderboard>(param);
        }

        #endregion Sync

        #region Async

        public async Task<ApiResponse<ChallengeIndex>> GetChallengeIndexAsync(Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.ChallengeIndex, Secret, new ChallengeModeBaseRequest(realm));
            return await CommunicateAsync<ChallengeIndex>(param);
        }

        public async Task<ApiResponse<ChallengeLeaderboard>> GetChallengeLeaderboardAsync(int mapId, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.ChallengeLeaderboard, Secret, new ChallengeModeLeaderboardRequest(mapId, realm));
            return await CommunicateAsync<ChallengeLeaderboard>(param);
        }

        #endregion Async
    }
}
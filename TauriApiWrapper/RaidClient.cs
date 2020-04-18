using System.Threading.Tasks;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses.Raid;

namespace TauriApiWrapper
{
    public sealed class RaidClient : TauriClient
    {
        private class Endpoints
        {
            public const string RaidMaps = "raid-maps";
            public const string RaidLog = "raid-log";
            public const string LatestRaids = "raid-last";
            public const string RaidPlayer = "raid-player";
        }

        public RaidClient(string apiKey, string secretKey) : base(apiKey, secretKey)
        {
        }

        #region Sync

        public ApiResponse<RaidMaps> GetRaidMaps(Realm realm = Realm.Evermoon)
        {
            ApiParams param = new ApiParams(Endpoints.RaidMaps, Secret, new RaidMapRequest(realm));
            return Communicate<RaidMaps>(param);
        }

        public ApiResponse<RaidLogsResponse> GetLatestRaids(int fromID = 0, int limit = 0, Realm realm = Realm.Evermoon)
        {
            ApiParams param = new ApiParams(Endpoints.LatestRaids, Secret, new RaidListRequest(realm, fromID: fromID, limit: limit));
            return Communicate<RaidLogsResponse>(param);
        }

        public ApiResponse<RaidLog> GetRaidLogFromId(int fromID, Realm realm = Realm.Evermoon)
        {
            ApiParams param = new ApiParams(Endpoints.RaidLog, Secret, new RaidLogRequest(fromID, realm));
            return Communicate<RaidLog>(param);
        }

        public ApiResponse<RaidLogsResponse> GetRaidLogFromPlayerName(string name, int fromID = 0, int limit = 0, Realm realm = Realm.Evermoon)
        {
            ApiParams param = new ApiParams(Endpoints.RaidPlayer, Secret, new PlayerRaidLogRequest(name, realm, fromID: fromID, limit: limit));
            return Communicate<RaidLogsResponse>(param);
        }

        #endregion Sync

        #region Async

        public async Task<ApiResponse<RaidMaps>> GetRaidMapsAsync(Realm realm = Realm.Evermoon)
        {
            ApiParams param = new ApiParams(Endpoints.RaidMaps, Secret, new RaidMapRequest(realm));
            return await CommunicateAsync<RaidMaps>(param);
        }

        public async Task<ApiResponse<RaidLogsResponse>> GetLatestRaidsAsync(int fromID = 0, int limit = 0, Realm realm = Realm.Evermoon)
        {
            ApiParams param = new ApiParams(Endpoints.LatestRaids, Secret, new RaidListRequest(realm, fromID: fromID, limit: limit));
            return await CommunicateAsync<RaidLogsResponse>(param);
        }

        public async Task<ApiResponse<RaidLog>> GetRaidLogFromIdAsync(int fromID, Realm realm = Realm.Evermoon)
        {
            ApiParams param = new ApiParams(Endpoints.RaidLog, Secret, new RaidLogRequest(fromID, realm));
            return await CommunicateAsync<RaidLog>(param);
        }

        public async Task<ApiResponse<RaidLog>> GetRaidLogFromPlayerNameAsync(string name, int fromID = 0, int limit = 0, Realm realm = Realm.Evermoon)
        {
            ApiParams param = new ApiParams(Endpoints.RaidPlayer, Secret, new PlayerRaidLogRequest(name, realm, fromID: fromID, limit: limit));
            return await CommunicateAsync<RaidLog>(param);
        }

        #endregion Async
    }
}
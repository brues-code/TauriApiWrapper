using System.Threading.Tasks;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses.Arena;

namespace TauriApiWrapper
{
    /*
     * 
     *  NYI in Tauri API
     *  
     */
    public class ArenaClient : TauriClient
    {
        private class Endpoints
        {
            public const string ArenaLadder = "arena-ladder";
            public const string TeamInfo = "team-info";
            public const string ArenaTeamGameChart = "arena-team-game-chart";
            public const string ArenaTeamReportOpposingTeams = "arena-team-report-opposing-teams";
            public const string ArenaGame = "arena-game";
        }
        public ArenaClient(string apiKey, string secretKey) : base(apiKey, secretKey)
        {
        }

        #region Sync

        public ApiResponse<ArenaLadder> GetArenaLadder(int teamSize, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.ArenaLadder, Secret, new ArenaLadderRequest(teamSize, realm));
            return Communicate<ArenaLadder>(param);
        }

        public ApiResponse<ArenaTeamInfo> GetArenaTeamInfo(int teamSize, string teamName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.TeamInfo, Secret, new ArenaTeamRequest(teamSize, teamName, realm));
            return Communicate<ArenaTeamInfo>(param);
        }

        public ApiResponse<ArenaTeamGameChart> GetArenaTeamGameChart(int teamSize, string teamName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.ArenaTeamGameChart, Secret, new ArenaTeamRequest(teamSize, teamName, realm));
            return Communicate<ArenaTeamGameChart>(param);
        }
        public ApiResponse<ArenaTeamReoprtOpposingTeams> GetArenaTeamReportOpposingTeams(int teamSize, string teamName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.ArenaTeamReportOpposingTeams, Secret, new ArenaTeamRequest(teamSize, teamName, realm));
            return Communicate<ArenaTeamReoprtOpposingTeams>(param);
        }

        public ApiResponse<ArenaGame> GetArenaGame(int matchId, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.ArenaGame, Secret, new ArenaGameRequest(matchId, realm));
            return Communicate<ArenaGame>(param);
        }

        #endregion Sync

        #region Async

        public async Task<ApiResponse<ArenaLadder>> GetArenaLadderAsync(int teamSize, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.ArenaLadder, Secret, new ArenaLadderRequest(teamSize, realm));
            return await CommunicateAsync<ArenaLadder>(param);
        }

        public async Task<ApiResponse<ArenaTeamInfo>> GetArenaTeamInfoAsync(int teamSize, string teamName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.TeamInfo, Secret, new ArenaTeamRequest(teamSize, teamName, realm));
            return await CommunicateAsync<ArenaTeamInfo>(param);
        }

        public async Task<ApiResponse<ArenaTeamGameChart>> GetArenaTeamGameChartAsync(int teamSize, string teamName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.ArenaTeamGameChart, Secret, new ArenaTeamRequest(teamSize, teamName, realm));
            return await CommunicateAsync<ArenaTeamGameChart>(param);
        }
        public async Task<ApiResponse<ArenaTeamReoprtOpposingTeams>> GetArenaTeamReportOpposingTeamsAsync(int teamSize, string teamName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.ArenaTeamReportOpposingTeams, Secret, new ArenaTeamRequest(teamSize, teamName, realm));
            return await CommunicateAsync<ArenaTeamReoprtOpposingTeams>(param);
        }

        public async Task<ApiResponse<ArenaGame>> GetArenaGameAsync(int matchId, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.ArenaGame, Secret, new ArenaGameRequest(matchId, realm));
            return await CommunicateAsync<ArenaGame>(param);
        }

        #endregion Async
    }
}
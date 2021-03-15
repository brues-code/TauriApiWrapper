using System;
using System.Threading.Tasks;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Extensions;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses.Arena;

namespace TauriApiWrapper
{
    [Obsolete("Currently not implemented in tauri, probably deprecated by them")]
    public class ArenaClient : TauriClient
    {
        private class Endpoints
        {
            public const string ArenaLadder = "arena-ladder";
            public const string TeamInfo = "team-info";
            public const string ArenaTeamGameChart = "arena-team-game-chart";
            public const string ArenaTeamReportOpposingTeams = "arena-team-report-opposing-teams"; // currently unused even on Crystalsong
            public const string ArenaGame = "arena-game"; // obsolete, use pvp-match instead
            public const string CharacterArenaTeams = "character-arenateams";
            public const string CharacterPvPStat = "character-pvp-stat";
            public const string PvPMatch = "pvp-match";
        }

        public ArenaClient(string apiKey, string secretKey) : base(apiKey, secretKey)
        {
        }

        #region Sync

        public ApiResponse<ArenaLadder> GetArenaLadder(int teamSize, Realm realm)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaLadder>() { CustomError = CustomError.InvalidRealm, ErrorMessage = InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.ArenaLadder, Secret, new ArenaLadderRequest(teamSize, realm));
            return Communicate<ArenaLadder>(param);
        }

        public ApiResponse<ArenaTeamInfo> GetArenaTeamInfo(int teamSize, string teamName, Realm realm)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaTeamInfo>() { CustomError = CustomError.InvalidRealm, ErrorMessage = InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.TeamInfo, Secret, new ArenaTeamRequest(teamSize, teamName, realm));
            return Communicate<ArenaTeamInfo>(param);
        }

        public ApiResponse<ArenaTeamGameChart> GetArenaTeamGameChart(int teamSize, string teamName, Realm realm)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaTeamGameChart>() { CustomError = CustomError.InvalidRealm, ErrorMessage = InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.ArenaTeamGameChart, Secret, new ArenaTeamRequest(teamSize, teamName, realm));
            return Communicate<ArenaTeamGameChart>(param);
        }

        public ApiResponse<ArenaTeamReportOpposingTeams> GetArenaTeamReportOpposingTeams(int teamSize, string teamName, Realm realm)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaTeamReportOpposingTeams>() { CustomError = CustomError.InvalidRealm, ErrorMessage = InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.ArenaTeamReportOpposingTeams, Secret, new ArenaTeamRequest(teamSize, teamName, realm));
            return Communicate<ArenaTeamReportOpposingTeams>(param);
        }

        public ApiResponse<ArenaGame> GetArenaGame(int matchId, Realm realm)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaGame>() { CustomError = CustomError.InvalidRealm, ErrorMessage = InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.ArenaGame, Secret, new ArenaGameRequest(matchId, realm));
            return Communicate<ArenaGame>(param);
        }

        #endregion Sync

        #region Async

        public async Task<ApiResponse<ArenaLadder>> GetArenaLadderAsync(int teamSize, Realm realm)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaLadder>() { CustomError = CustomError.InvalidRealm, ErrorMessage = InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.ArenaLadder, Secret, new ArenaLadderRequest(teamSize, realm));
            return await CommunicateAsync<ArenaLadder>(param);
        }

        public async Task<ApiResponse<ArenaTeamInfo>> GetArenaTeamInfoAsync(int teamSize, string teamName, Realm realm)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaTeamInfo>() { CustomError = CustomError.InvalidRealm, ErrorMessage = InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.TeamInfo, Secret, new ArenaTeamRequest(teamSize, teamName, realm));
            return await CommunicateAsync<ArenaTeamInfo>(param);
        }

        public async Task<ApiResponse<ArenaTeamGameChart>> GetArenaTeamGameChartAsync(int teamSize, string teamName, Realm realm)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaTeamGameChart>() { CustomError = CustomError.InvalidRealm, ErrorMessage = InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.ArenaTeamGameChart, Secret, new ArenaTeamRequest(teamSize, teamName, realm));
            return await CommunicateAsync<ArenaTeamGameChart>(param);
        }

        public async Task<ApiResponse<ArenaTeamReportOpposingTeams>> GetArenaTeamReportOpposingTeamsAsync(int teamSize, string teamName, Realm realm)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaTeamReportOpposingTeams>() { CustomError = CustomError.InvalidRealm, ErrorMessage = InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.ArenaTeamReportOpposingTeams, Secret, new ArenaTeamRequest(teamSize, teamName, realm));
            return await CommunicateAsync<ArenaTeamReportOpposingTeams>(param);
        }

        public async Task<ApiResponse<ArenaGame>> GetArenaGameAsync(int matchId, Realm realm)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaGame>() { CustomError = CustomError.InvalidRealm, ErrorMessage = InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.ArenaGame, Secret, new ArenaGameRequest(matchId, realm));
            return await CommunicateAsync<ArenaGame>(param);
        }

        #endregion Async
    }
}
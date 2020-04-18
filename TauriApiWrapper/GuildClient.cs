using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses.Guild;

namespace TauriApiWrapper
{
    public sealed class GuildClient : TauriClient
    {
        private class Endpoints
        {
            public const string GuildInfo = "guild-info";
            public const string GuildStats = "guild-stats";
            public const string GuildBankContents = "guild-bank-contents";
            public const string GuildBankLogs = "guild-bank-log";
        }

        public GuildClient(string apiKey, string secretKey) : base(apiKey, secretKey)
        {
        }

        public ApiResponse<GuildRoster> GetGuildRoster(string guildName, Realm realm = Realm.Evermoon)
        {
            ApiParams param = new ApiParams(Endpoints.GuildInfo, Secret, new GuildRequest(guildName, realm));
            return Communicate<GuildRoster>(param);
        }

        public ApiResponse<GuildStats> GetGuildStats(string guildName, Realm realm = Realm.Evermoon)
        {
            ApiParams param = new ApiParams(Endpoints.GuildStats, Secret, new GuildRequest(guildName, realm));
            return Communicate<GuildStats>(param);
        }

        public ApiResponse<GuildBankContent> GetGuildBankContents(string guildName, Realm realm = Realm.Evermoon)
        {
            ApiParams param = new ApiParams(Endpoints.GuildBankContents, Secret, new GuildRequest(guildName, realm));
            return Communicate<GuildBankContent>(param);
        }

        public ApiResponse<GuildBankLog> GetGuildBankLogs(string guildName, Realm realm = Realm.Evermoon)
        {
            ApiParams param = new ApiParams(Endpoints.GuildBankLogs, Secret, new GuildRequest(guildName, realm));
            return Communicate<GuildBankLog>(param);
        }
    }
}
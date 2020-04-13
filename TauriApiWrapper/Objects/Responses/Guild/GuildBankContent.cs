using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TauriApiWrapper.Objects.Responses.Guild
{
    public class GuildBankContent : BaseGuildInfo
    {
        [JsonProperty("guildMotd")]
        public string GuildMtod { get; set; }

        [JsonProperty("guildInfoText")]
        public string GuildInfoText { get; set; }

        [JsonProperty("guildBankTabs")]
        public Dictionary<int, GuildBankTab> GuildBankTabs { get; set; }

        [JsonProperty("GuildBankItemList")]
        public Dictionary<int, GuildBankItem> GuildBankItemList { get; set; }
    }
}
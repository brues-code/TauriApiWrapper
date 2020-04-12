using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Guild
{
    public sealed class GuildBankItem
    {
        [JsonProperty("tid")]
        public long Tid { get; set; }

        [JsonProperty("tabid")]
        public GuildBankTab Tabid { get; set; }

        [JsonProperty("sid")]
        public long Sid { get; set; }

        [JsonProperty("entry")]
        public long Entry { get; set; }

        [JsonProperty("Quality_original")]
        public long QualityOriginal { get; set; }

        [JsonProperty("Quality")]
        public long Quality { get; set; }

        [JsonProperty("name_original")]
        public string NameOriginal { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("classname")]
        public Class Class { get; set; }

        [JsonProperty("subclassname")]
        public string Subclassname { get; set; }

        [JsonProperty("icon_original")]
        public string IconOriginal { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("stackcount")]
        public long Stackcount { get; set; }

        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }

        [JsonProperty("slotid")]
        public string Slotid { get; set; }
    }
}
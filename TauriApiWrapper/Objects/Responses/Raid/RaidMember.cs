﻿using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Raid
{
    public sealed class RaidMember
    {
        [JsonProperty("valid_player")]
        public bool ValidPlayer { get; set; }

        [JsonProperty("guid")]
        public long Guid { get; set; }

        [JsonProperty("race")]
        public Race Race { get; set; }

        [JsonProperty("class")]
        public Class Class { get; set; }

        [JsonProperty("gender")]
        public byte Gender { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("spec")]
        public short Spec { get; set; }

        [JsonProperty("dmg_done")]
        public long DmgDone { get; set; }

        [JsonProperty("dmg_taken")]
        public long DmgTaken { get; set; }

        [JsonProperty("dmg_absorb")]
        public long DmgAbsorb { get; set; }

        [JsonProperty("heal_done")]
        public long HealDone { get; set; }

        [JsonProperty("absorb_done")]
        public long AbsorbDone { get; set; }

        [JsonProperty("overheal")]
        public long Overheal { get; set; }

        [JsonProperty("heal_taken")]
        public long HealTaken { get; set; }

        [JsonProperty("interrupts")]
        public short Interrupts { get; set; }

        [JsonProperty("dispells")]
        public short Dispells { get; set; }

        [JsonProperty("ilvl")]
        public short ItemLevel { get; set; }
    }
}

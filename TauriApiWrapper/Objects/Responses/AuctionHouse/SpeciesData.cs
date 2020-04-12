using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.AuctionHouse
{
    public sealed class SpeciesData
    {
        [JsonProperty("SpeciesID")]
        public long SpeciesID { get; set; }

        [JsonProperty("CreatureID")]
        public long CreatureID { get; set; }

        [JsonProperty("IconFileID")]
        public long IconFileId { get; set; }

        [JsonProperty("SummonSpellID")]
        public long SummonSpellID { get; set; }

        [JsonProperty("PetType")]
        public BattlePetType PetType { get; set; }
    }
}
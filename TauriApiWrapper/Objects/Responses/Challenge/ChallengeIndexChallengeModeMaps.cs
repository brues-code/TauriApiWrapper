using System;
using Newtonsoft.Json;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Converters;

namespace TauriApiWrapper.Objects.Responses.Challenge
{
    public partial class ChallengeIndexChallengeModeMaps
    {
        [JsonProperty("challengeid")]
        public int Challengeid { get; set; }

        [JsonProperty("challengemapid")]
        public int Challengemapid { get; set; }

        [JsonProperty("challengemapname")]
        public string Challengemapname { get; set; }

        [JsonProperty("goldmedaltime"), JsonConverter(typeof(TimeSpanSecondsConverter))]
        public TimeSpan Goldmedaltime { get; set; }

        [JsonProperty("silvermedaltime"), JsonConverter(typeof(TimeSpanSecondsConverter))]
        public TimeSpan Silvermedaltime { get; set; }

        [JsonProperty("bronzemedaltime"), JsonConverter(typeof(TimeSpanSecondsConverter))]
        public TimeSpan Bronzemedaltime { get; set; }
    }
}

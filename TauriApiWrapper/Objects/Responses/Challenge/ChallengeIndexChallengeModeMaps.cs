using System;
using Newtonsoft.Json;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Converters;

namespace TauriApiWrapper.Objects.Responses.Challenge
{
    public sealed class ChallengeIndexChallengeModeMaps
    {
        [JsonProperty("challengeid")]
        public int ChallengeId { get; set; }

        [JsonProperty("challengemapid")]
        public int ChallengeMapId { get; set; }

        [JsonProperty("challengemapname")]
        public string ChallengeMapName { get; set; }

        [JsonProperty("goldmedaltime"), JsonConverter(typeof(TimeSpanSecondsConverter))]
        public TimeSpan GoldMedalTime { get; set; }

        [JsonProperty("silvermedaltime"), JsonConverter(typeof(TimeSpanSecondsConverter))]
        public TimeSpan SilverMedalTime { get; set; }

        [JsonProperty("bronzemedaltime"), JsonConverter(typeof(TimeSpanSecondsConverter))]
        public TimeSpan BronzeMedalTime { get; set; }
    }
}
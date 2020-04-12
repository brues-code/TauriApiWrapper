using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.AuctionHouse
{
    public partial class BattlePet
    {
        [JsonProperty("battlepetdata")]
        public BattlePetData BattlePetData { get; set; }
    }
}
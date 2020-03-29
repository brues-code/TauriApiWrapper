using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TauriApiWrapper.Objects
{
    public class ApiParams
    {
        [JsonProperty(PropertyName = "secret")]
        public virtual string Secret { get; set; }

        [JsonProperty(PropertyName = "params")]
        public virtual IApiParam Params { get; set; }

        [JsonProperty(PropertyName = "url")]
        public virtual string Url { get; }

        public virtual string ToJSON()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
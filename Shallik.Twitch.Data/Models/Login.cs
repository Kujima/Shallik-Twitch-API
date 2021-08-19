using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shallik.Twitch.Data.Models
{
    public class Login
    {
        [JsonPropertyName("client_id")]
        public string client_id { get; set; }

        [JsonPropertyName("client_secret")]
        public string client_secret { get; set; }

        [JsonPropertyName("grant_type")]
        public string grant_type { get; set; }
    }
}

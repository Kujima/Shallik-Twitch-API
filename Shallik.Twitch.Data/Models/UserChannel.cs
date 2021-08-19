using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shallik.Twitch.Data.Models
{
    public class UserChannel
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("login")]
        public string login { get; set; }

        [JsonPropertyName("display_name")]
        public string display_name { get; set; }

        [JsonPropertyName("type")]
        public string type { get; set; }

        [JsonPropertyName("broadcaster_type")]
        public string broadcaster_type { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }

        [JsonPropertyName("profile_image_url")]
        public string profile_image_url { get; set; }

        [JsonPropertyName("offline_image_url")]
        public string offline_image_url { get; set; }

        [JsonPropertyName("view_count")]
        public int view_count { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime created_at { get; set; }
    }
}

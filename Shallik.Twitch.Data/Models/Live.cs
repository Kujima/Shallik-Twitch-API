using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shallik.Twitch.Data.Models
{
    public class Live
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("user_id")]
        public string user_id { get; set; }

        [JsonPropertyName("user_login")]
        public string user_login { get; set; }

        [JsonPropertyName("user_name")]
        public string user_name { get; set; }

        [JsonPropertyName("game_id")]
        public string game_id { get; set; }

        [JsonPropertyName("game_name")]
        public string game_name { get; set; }

        [JsonPropertyName("type")]
        public string type { get; set; }

        [JsonPropertyName("title")]
        public string title { get; set; }

        [JsonPropertyName("viewer_count")]
        public int viewer_count { get; set; }

        [JsonPropertyName("started_at")]
        public DateTime started_at { get; set; }

        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("thumbnail_url")]
        public string thumbnail_url { get; set; }

        [JsonPropertyName("tag_ids")]
        public List<string> tag_ids { get; set; }

        [JsonPropertyName("is_mature")]
        public bool is_mature { get; set; }
    }
}

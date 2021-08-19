using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shallik.Twitch.Data.Models
{
    public class OauthToken
    {
        public string access_token { get; set; }

        public int expires_in { get; set; }

        public string token_type { get; set; }
    }
}

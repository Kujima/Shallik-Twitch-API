using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shallik.Twitch.Data.Models
{
    public class DataRecipeUser
    {
        public List<UserChannel> data { get; set; }
    }
}

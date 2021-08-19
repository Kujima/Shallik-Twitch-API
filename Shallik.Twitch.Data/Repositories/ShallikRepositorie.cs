using Shallik.Twitch.Data.DataProviders;
using Shallik.Twitch.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shallik.Twitch.Data.Repositories
{
    public class ShallikRepositorie
    {
        private readonly ShallikProvider _shallikProvider;

        public ShallikRepositorie() 
        {
            _shallikProvider = new();
        }

        public async Task<Live> GetLive()
        {
            var shallikUser = await _shallikProvider.GetUser();
            var shallikLive = await _shallikProvider.GetLive(shallikUser);

            return shallikLive;
        }
    }
}

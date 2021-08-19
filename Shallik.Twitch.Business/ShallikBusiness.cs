using Shallik.Twitch.Data.Models;
using Shallik.Twitch.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shallik.Twitch.Business
{
    /// <summary>
    /// Class Business du controler Shallik
    /// </summary>
    public class ShallikBusiness
    {
        private readonly ShallikRepositorie _shallikRepositorie;

        /// <summary>
        /// Constructeur
        /// </summary>
        public ShallikBusiness()
        {
            _shallikRepositorie = new();
        }

        /// <summary>
        /// Retourne le live courant de Shallik
        /// </summary>
        /// <returns></returns>
        public async Task<Live> GetLive()
        {
            var live = await _shallikRepositorie.GetLive();

            return live;
        }
    }
}

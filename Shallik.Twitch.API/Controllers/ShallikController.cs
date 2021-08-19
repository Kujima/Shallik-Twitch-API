using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shallik.Twitch.Business;
using Shallik.Twitch.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shallik.Twitch.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShallikController : ControllerBase
    {
        private readonly ShallikBusiness _shallikBusiness;

        /// <summary>
        /// Constructeur du controlleur
        /// </summary>
        public ShallikController()
        {
            _shallikBusiness = new();
        }

        /// <summary>
        /// Retourne le live courant de Shallik
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<Live>> GetLive()
        {
            var live = await _shallikBusiness.GetLive();
            return live;
        }
    }
}

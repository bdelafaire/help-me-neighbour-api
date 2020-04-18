using HelpMeNeighbour.Models;
using HelpMeNeighbour.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpMeNeighbour.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AdController : ControllerBase
    {
        private IAdService _adService;

        public AdController(IAdService adService)
        {
            _adService = adService;
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var ads = _adService.GetAll();
            return Ok(ads);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Get(string id)
        {
            var ad = _adService.Get(id);
            return Ok(ad);
        }


        [HttpPost]
        public IActionResult Post([FromBody]AdModel ad)
        {
            var newAd = _adService.CreateAd(ad);
            return Ok(newAd);
        }


    }
}

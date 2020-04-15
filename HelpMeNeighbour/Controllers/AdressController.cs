using HelpMeNeighbour.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpMeNeighbour.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("search")]
    public class AdressController : ControllerBase
    {
        private IAdressService _adressService;
        public AdressController(IAdressService adressService)
        {
            _adressService = adressService;
        }

        [HttpGet]
        [Route("/adress")]
        public IActionResult Search([FromQuery]string adress)
        {
            var adresses = _adressService.Search(adress).Result;
            return Ok(adresses);
        }
    }
}

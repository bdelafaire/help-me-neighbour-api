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
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        private IAddressService _adressService;
        public AddressController(IAddressService adressService)
        {
            _adressService = adressService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("search")]
        public IActionResult Search([FromQuery]string q)
        {
            var adresses = _adressService.Search(q).Result;
            return Ok(adresses);
        }
    }
}

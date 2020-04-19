using HelpMeNeighbour.Entities;
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
    [Authorize]
    [Route("[controller]")]
    public class AdController : ControllerBase
    {
        IAdService _adservice;

        public AdController(IAdService adservice)
        {
            _adservice = adservice;
        }

        [Route("getall")]
        public IActionResult GetAll()
        {
            var ad =_adservice.GetAll();
            return Ok(ad);
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody]Ad adModel)
        {
            if (adModel == null || string.IsNullOrEmpty(adModel.Id))
            {
                return BadRequest(new { message = "Bad Json" });
            }
            var ad = _adservice.CreateAd(adModel);
            return Ok(ad);
        }

        [Route("{id}")]
        public IActionResult GetById(string id)
        {
            var ad = _adservice.GetById(id);
            return Ok(ad);
        }

        [Route("getbyuser/{id}")]
        public IActionResult GetByUser(string userid)
        {
            var ad = _adservice.GetByUserId(userid);
            return Ok(ad);
        }

    }
}

using HelpMeNeighbour.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpMeNeighbour.Controllers
{
    [Route("oauth")]
    public class OauthController : ControllerBase
    {
        IUserService _userService;
        public OauthController(IUserService user)
        {
            _userService = user;
        }

        [HttpGet]
        [Route("{token}")]
        public IActionResult GetByToken(string token)
        {
            var users = _userService.CheckToken(token);
            if (users == null)
            {
                return BadRequest("Invalid Token or Token expire");
            }
            return Ok(users);
        }
    }
}

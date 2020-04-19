using HelpMeNeighbour.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpMeNeighbour.Controllers
{
    public class Oauth : ControllerBase
    {
        IUserService _userService;
        public Oauth(IUserService user)
        {
            _userService = user;
        }

        [HttpGet]
        [Route("token/{token}")]
        public IActionResult GetByToken(string token)
        {
            var users = _userService.CheckToken(token);
            return Ok(users);
        }
    }
}

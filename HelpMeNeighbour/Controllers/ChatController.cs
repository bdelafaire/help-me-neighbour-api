using System;
using PusherServer;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using HelpMeNeighbour.Models;
using HelpMeNeighbour.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using HelpMeNeighbour.Entities;

namespace HelpMeNeighbour.Controllers 
{

    [Authorize]
    [Route("[controller]")]
    public class ChatController : ControllerBase 
    {

        readonly ActionExecutedContext _context;
        IPusherService _pusherService;
        IUserService _userService;


        public ChatController(IPusherService pusherService, IUserService userService, ActionExecutedContext context) {
            _pusherService = pusherService;
            _userService = userService;
            _context = context;
        }

        [HttpPost]
        [Route("message")]
        public ActionResult OnMessageReceived(MessageRequestModel message) 
        {
            User user = _userService.CheckToken(message.Token);
            MessageResponseModel responseMessage = new MessageResponseModel(message.AdId, message.UserId, message.Content);
            _pusherService.SendMessage(message.UserId, "new-message", responseMessage);
            return Ok();
        }
    }
}
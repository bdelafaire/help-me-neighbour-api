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

    [ApiController]
    [Route("[controller]")]
    public class ReviewController : ControllerBase
    {
        private IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Get(string id)
        {
            var user = _reviewService.Get(id);
            return Ok(user);
        }

        [AllowAnonymous]
        [HttpGet("reviews")]
        public IActionResult GetAll()
        {
            var users = _reviewService.GetAll();
            return Ok(users);
        }

        [AllowAnonymous]
        [HttpGet("givenReviews")]
        public IActionResult GetGivenRivews(string idUser)
        {
            var users = _reviewService.GetUserGivenReviewes(idUser);
            return Ok(users);
        }

        [AllowAnonymous]
        [HttpGet("receivedReviews")]
        public IActionResult GetReceivedRivews(string idUser)
        {
            var users = _reviewService.GetUserReceivedReviews(idUser);
            return Ok(users);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Post([FromBody]Review review)
        {
            var newReview = _reviewService.Create(review);
            return Ok(newReview);
        }


    }
}

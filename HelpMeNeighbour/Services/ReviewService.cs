using HelpMeNeighbour.Data;
using HelpMeNeighbour.Entities;
using HelpMeNeighbour.Helper;
using HelpMeNeighbour.Models;
using HelpMeNeighbour.Security;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HelpMeNeighbour.Services
{
    public interface IReviewService
    {
        Review Get(string id);
        ICollection<Review> GetAll();
        Review Create(Review user);
        ICollection<Review> GetUserReceivedReviews(string idUser);
        ICollection<Review> GetUserGivenReviewes(string idUser);
    }

    public class ReviewService : IReviewService
    {
        ApplicationDbContext _context;
        private readonly AppSettings _appSettings;

        public ReviewService(IOptions<AppSettings> appSettings, ApplicationDbContext context)
        {
            _appSettings = appSettings.Value;
            _context = context;
        }

        public Review Create(Review review)
        {
            var addedReview = _context.Add(review);
            _context.SaveChanges();

            return addedReview.Entity;
        }
        public ICollection<Review> GetUserReceivedReviews(string idUser)
        {
            var receivedReviews = _context.Review.Where(review => review.IdReviewed == idUser).ToList();

            return receivedReviews;
        }
        public ICollection<Review> GetUserGivenReviewes(string idUser)
        {
            var reviewsGiven = _context.Review.Where(review => review.IdReviewer == idUser).ToList();

            return reviewsGiven;
        }

        public ICollection<Review> GetAll()
        {
            return _context.Review.ToList();
        }

        public Review Get(string id)
        {
            return _context.Review.First(review => review.Id == id);
        }

    }
}

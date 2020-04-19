using HelpMeNeighbour.Data;
using HelpMeNeighbour.Entities;
using HelpMeNeighbour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpMeNeighbour.Services
{
    public interface IAdService
    {
        Ad CreateAd(Ad ad);
        ICollection<Ad> GetAll();
        Ad GetById(string id);
        ICollection<Ad> GetByUserId(string userId);
    }
    public class AdService : IAdService
    {
        ApplicationDbContext _context;

        public AdService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Ad CreateAd(Ad ad)
        {
            _context.Add(ad);
            _context.SaveChanges();
            return ad;
        }

        public ICollection<Ad> GetAll()
        {
            return _context.Ad.OrderBy(a => a.Title).ToList();
        }

        public Ad GetById(string id)
        {
            return _context.Ad.Where(a => a.Id == id).First();
        }

        public ICollection<Ad> GetByUserId(string userId)
        {
            return _context.Ad.Where(a => a.User.Id == userId).ToList();
        }
    }
}

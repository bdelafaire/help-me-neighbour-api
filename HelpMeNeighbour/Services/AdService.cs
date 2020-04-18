using AutoMapper;
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
    public interface IAdService
    {
        IEnumerable<Ad> GetAll();
        Ad Get(string id);
        Ad CreateAd(AdModel ad);
    }

    public class AdService : IAdService
    {
        ApplicationDbContext _context;
        private readonly AppSettings _appSettings;
        private readonly IMapper _mapper;

        public AdService(IOptions<AppSettings> appSettings, ApplicationDbContext context, IMapper mapper)
        {
            _appSettings = appSettings.Value;
            _context = context;
            _mapper = mapper;
        }

        public Ad CreateAd(AdModel ad)
        {
            var mappedAd = _mapper.Map<Ad>(ad);
            _context.Add(mappedAd);
            _context.SaveChanges();

            return mappedAd;
        }

        public IEnumerable<Ad> GetAll()
        {
            return _context.Ad;
        }

        public Ad Get(string id)
        {
            return _context.Ad.First(ad => ad.Id == id);
        }
    }
}

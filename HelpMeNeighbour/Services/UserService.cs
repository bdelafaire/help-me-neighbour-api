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
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
        User CheckToken(string token);
        User CreateUser(UserModel user);
    }

    public class UserService : IUserService
    {
        ApplicationDbContext _context;
        IPasswordHasher _passwordHasher;
        private readonly AppSettings _appSettings;

        public UserService(IOptions<AppSettings> appSettings, ApplicationDbContext context, IPasswordHasher passwordHasher)
        {
            _appSettings = appSettings.Value;
            _context = context;
            _passwordHasher = passwordHasher;
        }

        public User Authenticate(string email, string password)
        {
            var user = _context.User.Single(user => user.Email == email);

            // return null if user not found
            if (user == null)
                return null;


            if (!_passwordHasher.Check(password, user.Password))
            {
                return null;
            }
            
            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            return user.WithoutPassword();
        }

        public User CreateUser(UserModel user)
        {
            string hash = _passwordHasher.Hash(user.Password);
            User userToAdd = new User
            {
                Id = user.Id,
                LastName = user.LastName,
                FirstName = user.FirstName,
                Email = user.Email,
                Address = user.Address,
                Password = hash
            };
            _context.Add(userToAdd);
            _context.SaveChanges();

            return userToAdd.WithoutPassword();
        }

        public IEnumerable<User> GetAll()
        {
            return _context.User.WithoutPasswords();
        }

        public User CheckToken(string token)
        {
            JwtSecurityTokenHandler jwtTokenHandler = new JwtSecurityTokenHandler();
            var jwtToken = jwtTokenHandler.ReadJwtToken(token);
            return new User();
        }
    }
}

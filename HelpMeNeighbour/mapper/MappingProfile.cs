using AutoMapper;
using HelpMeNeighbour.Entities;
using HelpMeNeighbour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpMeNeighbour.mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<UserModel, User>();

            CreateMap<Ad, AdModel>();
            CreateMap<AdModel, Ad>();
        }
    }
}

using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService
    {
        public static List<UserDTO> Get()
        {
            var data = DataAccessFactory.UserData().Read();

            var cfg = new MapperConfiguration(c => {
                c.CreateMap<User, UserDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<UserDTO>>(data);

            return mapped;
        }

        public static UserDTO Get(string email)
        {
            var data = DataAccessFactory.UserData().Read(email);

            var cfg = new MapperConfiguration(c => {
                c.CreateMap<User, UserDTO>();
            });

            var mapper = new Mapper(cfg);

            var mapped = mapper.Map<UserDTO>(data);

            return mapped;
        }
    }
}

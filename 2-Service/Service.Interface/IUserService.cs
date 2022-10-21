using Microsoft.AspNetCore.Mvc;
using SoupLocal._1_Core.Entities;
using SoupLocal._1_Core.Entities.SubEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoupLocal._2_Service.Service.Interface
{
    public interface IUserService
    {
        public Task<bool> Create([FromBody] User user);
        public Task<List<loginUser>> GetPass(string email);
        public Task<User> GetUser(string email);
        public Task<string> Login([FromBody] loginUser user);
        public Task<bool> Update([FromBody] loginUser user);

        /*        public Task<bool> Delete([FromBody] int id);*/
        /*        public Task<List<User>> Get();*/
    }
}

using GameShop.Data.interfaces;
using GameShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Data.Repository
{
    public class UserRepository : IAllUsers
    {
        private readonly AppDBContent appDBContent;

        public UserRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Users> AllUsers => appDBContent.Users;

        public Users GetUser(int id) => appDBContent.Users.FirstOrDefault(p=> p.Id==id );
    }
}

using GameShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Data.interfaces
{
    public interface IAllUsers
    {
        IEnumerable<Users> AllUsers { get; }
        Users GetUser(int id);
    }
}

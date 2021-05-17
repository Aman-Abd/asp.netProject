using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public double Money { get; set; }
        public List<Game> Games { get; set; }
        public double Donation { get; set; }
    }
}

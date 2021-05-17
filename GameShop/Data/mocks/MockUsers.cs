using GameShop.Data.interfaces;
using GameShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Data.mocks
{
    public class MockUsers : IAllUsers
    {
        public IEnumerable<Users> AllUsers
        {
            get
            {
                return new List<Users>
                {
                    new Users {
                        Id = 0 ,
                        Name = "Aman",
                        Password = "123",
                        Money = 10000.0,
                        Donation = 0,
                        Games = new List<Game>
                        {
                            new Game
                            {
                                Id = 0,
                                Name = "GTA",
                                Price = 2000,
                                Image = "https://upload.wikimedia.org/wikipedia/ru/c/c8/GTAV_Official_Cover_Art.jpg"
                            }
                        }
                    }
                };
            }
            set
            {

            }
        }

        public Users GetUser(int id)
        {
            foreach(Users User in AllUsers){
                if (id == User.Id)
                    return User;
            }
            return null;
        }

    }
}

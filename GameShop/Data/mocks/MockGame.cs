using GameShop.Data.interfaces;
using GameShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Data.mocks
{
    public class MockGame : IAllGames
    {
        public IEnumerable<Game> AllGames
        {
            get
            {
                return new List<Game>
                {
                    new Game
                    {
                        Id = 0,
                        Name = "FIFA2020",
                        Price = 1200,
                        Image = "https://logincasino.com/uploads/gallery/65235/thumbs/o750_400_optim_m_8f064b1305ad0d6d1a229b612a93c47d.jpg"
                    },
                    new Game
                    {
                        Id = 1,
                        Name = "Assassin's Creed Valhalla",
                        Price = 3000,
                        Image = "https://www.gamingscan.com/wp-content/uploads/2020/09/Assassins-Creed-Valhalla-1.jpg"
                    },
                     new Game
                     {
                        Id = 2,
                        Name = "UFC3",
                        Price = 2000,
                        Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTxHlGlu250TGiDOVf8HKG5bG2-x2tBJSqn5_OZxk8c92LrxamtE7wM2aucXl6Sd8bHVQE&usqp=CAU"
                     }
                };
            }
        }

        public Game GetGame(int gameId)
        {
            foreach (Game game in AllGames) { 
                if(gameId == game.Id)
                {
                    return game;
                } 
            }
            return null;
        }
    }
}

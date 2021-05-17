using GameShop.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Data
{
    public class DbObjects
    {
        public static void Initial(AppDBContent content)
        {
            
            if (!content.Games.Any())
            {
                content.Games.AddRange(Games.Select(c=> c.Value));

            }

            if (!content.Users.Any())
            {
                content.AddRange(
                        new Users { 
                            Id = 0 , 
                            Name = "Aman", 
                            Password = "123", 
                            Games = new List<Game>
                            {
                                new Game
                                {
                                    Id = 0,
                                    Name = "GTA",
                                    Price = 2000
                                }
                            }
                        }
                    );
            }
            content.SaveChanges();

        }

        private static Dictionary<string, Game> game;
        public static Dictionary<string, Game> Games
        {
            get
            {
                if(game == null)
                {
                    var list = new Game[]
                    {
                        new Game
                        {
                       
                            Name = "FIFA2020",
                            Price = 1200,
                            Image = "https://logincasino.com/uploads/gallery/65235/thumbs/o750_400_optim_m_8f064b1305ad0d6d1a229b612a93c47d.jpg"
                        },
                        new Game
                        {
                         
                            Name = "UFC3",
                            Price = 2000,
                            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQb3E9Waqig73L85o41j-NU5dVkr99grVULEw&usqp=CAU"
                        }
                    };
                    game = new Dictionary<string, Game>();
                    foreach(Game g in list)
                    {
                        game.Add(g.Name, g);
                    }
                }

                return game;
            }
        }
    }
}

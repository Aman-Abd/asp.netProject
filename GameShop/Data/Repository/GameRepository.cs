using GameShop.Data.interfaces;
using GameShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Data.Repository
{
    public class GameRepository : IAllGames
    {
        private readonly AppDBContent appDBContent;
        public GameRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Game> AllGames => appDBContent.Games;

        public Game GetGame(int gameId) => appDBContent.Games.FirstOrDefault(p => p.Id == gameId);


    }
}

using GameShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Data.interfaces
{
    public interface IAllGames
    {
        IEnumerable<Game> AllGames { get; }
        Game GetGame(int gameId);
    }
}

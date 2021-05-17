using GameShop.Data.interfaces;
using GameShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllGames _allGames;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IAllGames allGames)
        {
            _logger = logger;
            _allGames = allGames;
        }

        public IActionResult Index()
        {
            IEnumerable<Game> games = _allGames.AllGames;
 
            return View(games);
        }

        public IActionResult Buy(int id)
        {
            IAllGames games = _allGames;
            Users user = CurrentUser.GetCurrentUser().User;
            if(user != null)
            {
                Game game = games.GetGame(id);

                if (user.Money >= game.Price)
                {
                    user.Money -= game.Price;
                    user.Games.Add(game);
                    user.Donation = user.Donation + game.Price * 0.1;
                    ViewData["Message"] = "Game added";
                }
                else
                {
                    ViewData["Message"] = "Not enough money ";
                }
            }
            else
            {
                ViewData["Message"] = "Login first";
            }

            return View("Index", games.AllGames);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

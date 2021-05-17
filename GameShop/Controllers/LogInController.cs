using GameShop.Data.interfaces;
using GameShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Controllers
{
    public class LogInController : Controller
    {
        private readonly IAllUsers allUser;
        public LogInController(IAllUsers allUsers)
        {
            allUser = allUsers;
        }
        // GET: LogInController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(string login, string password)
        {
            foreach(var user in allUser.AllUsers)
            {
                if (user.Name == login && password == user.Password)
                {
                    ViewData["Name"] = login;
                    CurrentUser.GetCurrentUser().User = user;
                    return View("Success");
                }
                else
                {
                    ViewData["Error"] = "Wrong password or login";
                    return View("Index");
                }                 
            }
            return View();
        }

        /*// GET: LogInController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LogInController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LogInController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LogInController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LogInController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LogInController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LogInController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/
    }
}

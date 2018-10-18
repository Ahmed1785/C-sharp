using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using login.Models;
using Microsoft.AspNetCore.Mvc;

namespace login.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Create(string FirstName, string LastName, int Age, string Email, string Password)
        {
            User newUser = new User(){
                FirstName = FirstName,
                LastName = LastName,
                Age = Age,
                Email = Email, 
                Password = Password
            };

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

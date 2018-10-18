using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using loginform.Models;

namespace loginform.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
                return View();

        }

        [HttpPost]
        [Route("register")]
        public IActionResult About(string FirstName, string LastName, int Age, string Email, string Password)
        {
            User newUser = new User(){
                FirstName = FirstName,
                LastName = LastName,
                Age = Age,
                Email = Email, 
                Password = Password
            };
            // Console.WriteLine(newUser.FirstName);
            // Console.WriteLine(user.FirstName);
            if(TryValidateModel(newUser) == false){
                System.Console.WriteLine(newUser);
                ViewBag.errors = ModelState.Values;
                Console.WriteLine(ViewBag.errors);

            return View("Index");
              }else{
                return View("Success");
              }
              

        // public IActionResult Contact()
        // {
        //     ViewData["Message"] = "Your contact page.";

        //     return View();
        // }

        // public IActionResult Error()
        // {
        //     return View();
        }
    }
}

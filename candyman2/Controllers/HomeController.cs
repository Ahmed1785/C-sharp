using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DbConnection;

namespace candyman2.Controllers
{
    public class HomeController : Controller
    {
        private DbConnector qdj; 
        public HomeController() 
        {
            qdj = new DbConnector();
        }
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            // List<Dictionary<string, object>> AllUsers = DbConnector.Query("SELECT * FROM users");
            return View("Index");
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult AddQuote(string name, string Quotes, string create_time)
        {
            // Console.WriteLine(name);
            // Console.WriteLine(quote);
            string query = $"INSERT INTO user (name, Quotes, create_time) VALUES ('{name}', '{Quotes}', NOW())";
            DbConnector.Execute(query);
            return RedirectToAction("Index");
        }

        // public IActionResult Contact()
        // {
        //     ViewData["Message"] = "Your contact page.";

        //     return View();
        // }

        // public IActionResult Error()
        // {
        //     return View();
        // }
    }
}

using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dojodaichi.Controllers
{
    public class DojodaichiController : Controller
    {
        // public int Fullness = 20; 
        // public int Happiness = 20;
        // public int Meals = 20;
        // public int Energy = 20;

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            int? Fullness = HttpContext.Session.GetInt32("Fullness");
            if(Fullness == null)
            {
                Fullness = 20;
            }

            int? Happiness = HttpContext.Session.GetInt32("Happiness");
            if(Happiness == null)
            {
                Happiness = 20;
            }

            int? Meals = HttpContext.Session.GetInt32("Meals");
            if(Meals == null)
            {
                Meals = 3;
            }

            int? Energy = HttpContext.Session.GetInt32("Energy");
            if(Energy == null)
            {
                Energy = 50;
            }

            HttpContext.Session.SetInt32("Fullness", (int)Fullness);
            HttpContext.Session.SetInt32("Happiness", (int)Happiness);
            HttpContext.Session.SetInt32("Meals", (int)Meals);
            HttpContext.Session.SetInt32("Energy", (int)Energy);


            ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
            ViewBag.Meals = HttpContext.Session.GetInt32("Meals");
            ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
            // Feed = 20;
            // Happiness = 20;
            // Meals = 20;
            // Energy= 20;
            return View();
        }
        [HttpPost]
        [Route("Feed")]
        public IActionResult Feed()
        {
            
            Random rand = new Random();
            
            int? Fullness = HttpContext.Session.GetInt32("Fullness");
            int? Happiness = HttpContext.Session.GetInt32("Happiness");
            int? Meals = HttpContext.Session.GetInt32("Meals");
            int? Energy = HttpContext.Session.GetInt32("Energy");
            if (Fullness == null || Happiness == null || Meals == null || Energy == null)
            {
                Fullness = 20;

                Happiness = 20;

                Meals = 3;

                Energy = 50;
            }

            int chance = rand.Next(1,5);
            if(chance == 1){
                Meals -= 1;
            }

            if(Meals != 0){
            Meals -= 1;
            Fullness += rand.Next(5,11);
            }else{
                Console.WriteLine("You lose");
            }

            HttpContext.Session.SetInt32("Meals", (int)Meals);
            HttpContext.Session.SetInt32("Fullness", (int)Fullness);

            return RedirectToAction("Index");
        }
        [HttpPost]
        [Route("Play")]
        public IActionResult Play()
        {
            Random rand = new Random();
            int? Fullness = HttpContext.Session.GetInt32("Fullness");
            int? Happiness = HttpContext.Session.GetInt32("Happiness");
            int? Meals = HttpContext.Session.GetInt32("Meals");
            int? Energy = HttpContext.Session.GetInt32("Energy");
            if (Fullness == null || Happiness == null || Meals == null || Energy == null)
            {
                Fullness = 20;

                Happiness = 20;

                Meals = 3;

                Energy = 50;
            }

            int chance = rand.Next(1,5);
            if(chance == 1){
                Energy -= 5;
            }

            if(Energy != 0){
            Energy -= 5;
            Happiness += rand.Next(5,11);
            }else{
                Console.WriteLine("You lose");
            }

            HttpContext.Session.SetInt32("Energy", (int)Energy);
            HttpContext.Session.SetInt32("Happiness", (int)Happiness);

            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("Sleep")]
        public IActionResult Sleep()
        {
            Random rand = new Random();
            int? Fullness = HttpContext.Session.GetInt32("Fullness");
            int? Happiness = HttpContext.Session.GetInt32("Happiness");
            int? Meals = HttpContext.Session.GetInt32("Meals");
            int? Energy = HttpContext.Session.GetInt32("Energy");
            if (Fullness == null || Happiness == null || Meals == null || Energy == null)
            {
                Fullness = 20;

                Happiness = 20;

                Meals = 3;

                Energy = 50;
            }

            if(Energy != 0 && Meals != 0){
            Energy += 15;
            Fullness -= 5;
            Happiness -= 5;
            }else{
                Console.WriteLine("You lose");
            }

            if(Energy == 100 && Fullness == 100 && Happiness == 100){
                System.Console.WriteLine("You Win!");
            }

            HttpContext.Session.SetInt32("Energy", (int)Energy);
            HttpContext.Session.SetInt32("Happiness", (int)Happiness);
            HttpContext.Session.SetInt32("Fullness", (int)Fullness);

            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("Restart")]
        public IActionResult Restart()
        {

            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
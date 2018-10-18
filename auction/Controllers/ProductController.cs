using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using auction.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
// using Wall.Models;

namespace auction.Controllers
{
    public class ProductController : Controller
    {

        private MainContext _context;

        public ProductController(MainContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("productform")]
        public IActionResult Weddingform()
        {

            return View("Product");
        }

        [HttpPost]
        [Route("addproduct")]
        public IActionResult addproduct(Product products)
        {
            Console.WriteLine("this is a test ***************************");
            int? loggedperson = HttpContext.Session.GetInt32("loggedperson");
            if(ModelState.IsValid)
            {
                Console.WriteLine("step1");
                Product NewProduct = new Product
                {
                    name = products.name,
                    description = products.description,
                    startingbid = (int)products.startingbid,
                    date = products.date,
                    user_id = (int)loggedperson
                };
                Console.WriteLine("step2");
                _context.Add(NewProduct).ToString();
                _context.SaveChanges();
                System.Console.WriteLine("NEW Message", products.name);
                ViewBag.Success = "You have been added to the database! Please log in now!";

                return RedirectToAction("LandingPage", "Home");
            }
            
            return RedirectToAction("LandingPage", "Home");
        }

        [HttpPost]
        [Route("viewproduct/{product_id}")]
        public IActionResult Show(int product_id)
        {
            if(HttpContext.Session.GetInt32("loggedperson") == null)
               return RedirectToAction("Index");
            
            
            var oneproduct = _context.product.Include(p => p.user_id).Where(w => w.user_id == product_id).SingleOrDefault();
            ViewBag.oneproduct = oneproduct;

            return View("ShowProduct");
        }

        [HttpGet]
        [Route("deleteproduct/{product_id}")]

        public IActionResult deleteproduct(int product_id)
        
        {
            int? loggedperson = HttpContext.Session.GetInt32("loggedperson");
            System.Console.WriteLine("LOGGESPERSON " + loggedperson);
            if (loggedperson == null){
                return RedirectToAction("Index", "Home");
            }else{
        
            
            
            var deleteaproduct = _context.product.Include(u => u.user_id).Where(w => w.user_id == product_id).SingleOrDefault();
            _context.Remove(deleteaproduct);
            _context.SaveChanges();
            return RedirectToAction("LandingPage", "Home");
            }

        }
    }
}
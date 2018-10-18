using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace testing.Controllers
{
    public class SurveyController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult index()
        {
            ViewBag.Errors = new List<string>();
            return View();
        }
        

        [HttpPost]
        [Route("/success")]
        public IActionResult success(string name, string comment, string location, string language)
        {
            ViewBag.Errors = new List<string>();

            if(ViewBag.Name == null)
            {
                ViewBag.Errors.Add("Name cannot be empty");
            }

            if(ViewBag.Comment == null)
            {
                ViewBag.Errors.Add("Comment cannot be empty");
            }

            // if(ViewBag.Errors.Count > 0)
            // {
            //     return View("Index");
            // }

            ViewBag.Name = name;
            ViewBag.Comment = comment;
            ViewBag.Language = language;
            ViewBag.Location = location;

            return View("success");
        }

    }







}
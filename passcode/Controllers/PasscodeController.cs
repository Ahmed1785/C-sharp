using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;

namespace DojoSurvey.Controllers
{
    public class PasscodeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            int? RunCount = HttpContext.Session.GetInt32("RunCount");
            if(RunCount == null)
            {
                RunCount = 0;
            }
            RunCount += 1;
            string alphanumeric = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string passcode = "";
            Random rand = new Random();
            for(int i = 0; i < 14; i++)
            {
                passcode = passcode + alphanumeric[rand.Next(0, alphanumeric.Length)];
            }
            ViewBag.passcode = passcode;
            ViewBag.RunCount = RunCount;
            HttpContext.Session.SetInt32("RunCount", (int)RunCount);
            return View();
        }
    }
}
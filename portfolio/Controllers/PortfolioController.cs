using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace YourNamespace.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("index")]
        public IActionResult index()
        {
            // return View();
            //OR
            return View("index");
            //Both of these returns will render the same view (You only need one!)
        }
    }

    public class PortfolioController : Controller
    {
        [HttpGet]
        [Route("/portfolio")]
        public IActionResult portfolio()
        {
            // return View();
            //OR
            return View("portfolio");
            //Both of these returns will render the same view (You only need one!)
        }
    }

    public class ContactController : Controller
    {
        [HttpGet]
        [Route("/contact")]
        public IActionResult portfolio()
        {
            // return View();
            //OR
            return View("contact");
            //Both of these returns will render the same view (You only need one!)
        }
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace YourNamespace.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult index()
        {
            // return View();
            //OR
            return View("index");
            //Both of these returns will render the same view (You only need one!)
        }
    }
}
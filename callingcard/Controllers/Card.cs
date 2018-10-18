using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace YourNamespace.Controllers
{
    public class CallingCardController : Controller
    {
        [HttpGetAttribute]
        [HttpGet]
        [Route("/{firstname}/{lastname}/{age}/{color}")]
        public JsonResult Callingcard(string firstname, string lastname, int age, string color)
        {
            return Json(new{firstname = firstname, lastname = lastname, age = age, color = color});
        }
    }
}
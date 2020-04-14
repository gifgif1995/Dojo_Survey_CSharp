using Microsoft.AspNetCore.Mvc;
namespace HomeController.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("results")]
        public IActionResult Results(string name, string location, string language, string textarea)
        {
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.textarea = textarea;
            return View();
        }
    }
}
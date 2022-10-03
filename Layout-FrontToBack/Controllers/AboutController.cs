using Microsoft.AspNetCore.Mvc;

namespace Layout_FrontToBack.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

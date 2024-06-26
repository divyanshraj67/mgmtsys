using Microsoft.AspNetCore.Mvc;

namespace mgmtsys.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}

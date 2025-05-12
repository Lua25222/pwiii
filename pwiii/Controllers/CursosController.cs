using Microsoft.AspNetCore.Mvc;

namespace pwiii.Controllers
{
    public class CursosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
